"use strict";

// Class definition
var KTWizard5 = function () {
	// Base elements
	var _wizardEl;
	var _formEl;
	var _wizardObj;
	var _validations = [];

	// Private functions
	var _initWizard = function () {
		// Initialize form wizard
		_wizardObj = new KTWizard(_wizardEl, {
			startStep: 1, // initial active step number
			clickableSteps: false  // allow step clicking
		});

		// Validation before going to next page
		_wizardObj.on('change', function (wizard) {
			if (wizard.getStep() > wizard.getNewStep()) {
				return; // Skip if stepped back
			}

			// Validate form before change wizard step
			var validator = _validations[wizard.getStep() - 1]; // get validator for currnt step

			if (validator) {
				validator.validate().then(function (status) {
					if (status == 'Valid') {
						wizard.goTo(wizard.getNewStep());

						KTUtil.scrollTop();
					} else {
						Swal.fire({
							text: "Xin lỗi, có vẻ như đã phát hiện thấy một số lỗi, vui lòng thử lại.",
							icon: "error",
							buttonsStyling: false,
							confirmButtonText: "Ok",
							customClass: {
								confirmButton: "btn font-weight-bold btn-light"
							}
						}).then(function () {
							KTUtil.scrollTop();
						});
					}
				});
			}

			return false;  // Do not change wizard step, further action will be handled by he validator
		});

		// Change event
		_wizardObj.on('changed', function (wizard) {
			KTUtil.scrollTop();
			// My Edit
			const form = document.getElementById('kt_form');
			document.getElementById("reviewUserName").innerHTML = "Tên đăng nhập : " + form.querySelector('[name="UserName"]').value;
			document.getElementById("reviewPassword").innerHTML = "Mật khẩu : " + form.querySelector('[name="Password"]').value;
			document.getElementById("reviewFullName").innerHTML = "Họ và tên : " + form.querySelector('[name="LastName"]').value + " " + form.querySelector('[name="FirstName"]').value;
			document.getElementById("reviewEmail").innerHTML = "Email : " + form.querySelector('[name="Email"]').value;
			document.getElementById("reviewPhoneNumber").innerHTML = "Số điện thoại : " + form.querySelector('[name="PhoneNumber"]').value;
			document.getElementById("reviewDob").innerHTML = "Ngày sinh : " + form.querySelector('[name="Dob"]').value;
			// My Edit
		});

		// Submit event
		_wizardObj.on('submit', function (wizard) {
			Swal.fire({
				text: "Mọi thứ đều tốt! Vui lòng xác nhận việc gửi biểu mẫu.",
				icon: "success",
				showCancelButton: true,
				buttonsStyling: false,
				confirmButtonText: "Xác Nhận!",
				cancelButtonText: "Không, huỷ bỏ",
				customClass: {
					confirmButton: "btn font-weight-bold btn-primary",
					cancelButton: "btn font-weight-bold btn-default"
				}
			}).then(function (result) {
				if (result.value) {
					_formEl.submit(); // Submit form
				} else if (result.dismiss === 'cancel') {
					Swal.fire({
						text: "Biểu mẫu của bạn chưa được gửi!.",
						icon: "error",
						buttonsStyling: false,
						confirmButtonText: "Ok, đã rõ!",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary",
						}
					});
				}
			});
		});
	}

	var _initValidation = function () {
		// Init form validation rules. For more info check the FormValidation plugin's official documentation:https://formvalidation.io/
		// Step 1
		const step1 = FormValidation.formValidation(
			_formEl,
			{
				fields: {
					UserName: {
						validators: {
							notEmpty: {
								message: 'Tên đăng nhập không được để trống.'
							}
						}
					},
					Password: {
						validators: {
							notEmpty: {
								message: 'Mật khẩu không được để trống.'
							}
						}
					},
					ConfirmPassword: {
						validators: {
							identical: {
								compare: function () {
									return _formEl.querySelector('[name="Password"]').value;
								},
								message: 'Không khớp với mật khẩu đã nhập.'
							}
						}
					},
				},
				plugins: {
					trigger: new FormValidation.plugins.Trigger(),
					// Bootstrap Framework Integration
					bootstrap: new FormValidation.plugins.Bootstrap({
						//eleInvalidClass: '',
						eleValidClass: '',
					}),
					icon: new FormValidation.plugins.Icon({
						valid: 'fa fa-check',
						invalid: 'fa fa-times',
						validating: 'fa fa-refresh'
					}),
				}
			}
		);
		_validations.push(step1);
		_formEl.querySelector('[name="Password"]').addEventListener('input', function () {
			step1.revalidateField('ConfirmPassword');
		});

		// Step 2
		_validations.push(FormValidation.formValidation(
			_formEl,
			{
				fields: {
					FirstName: {
						validators: {
							notEmpty: {
								message: 'Tên không được để trống.'
							},
							stringLength: {
								max: 10,
								message: 'Tên không được quá 10 ký tự.'
							}
						}
					},
					LastName: {
						validators: {
							notEmpty: {
								message: 'Họ không được để trống.'
							},
							stringLength: {
								max: 20,
								message: 'Họ không được quá 20 ký tự.'
							}
						}
					},
				},
				plugins: {
					trigger: new FormValidation.plugins.Trigger(),
					// Bootstrap Framework Integration
					bootstrap: new FormValidation.plugins.Bootstrap({
						//eleInvalidClass: '',
						eleValidClass: '',
					}),
					icon: new FormValidation.plugins.Icon({
						valid: 'fa fa-check',
						invalid: 'fa fa-times',
						validating: 'fa fa-refresh'
					}),
				}
			}
		));
	}

	return {
		// public functions
		init: function () {
			_wizardEl = KTUtil.getById('kt_wizard');
			_formEl = KTUtil.getById('kt_form');

			_initWizard();
			_initValidation();
		}
	};
}();

jQuery(document).ready(function () {
	KTWizard5.init();
});
