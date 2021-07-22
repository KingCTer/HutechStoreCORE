var SiteController = function () {
    this.initialize = function () {
        regsiterEvents();
        loadData();
    }

    this.initializeCart = function () {
        loadCart();
    }

    const culture = $('#hidCulture').val();

    function regsiterEvents() {
        // Write your JavaScript code.
        $('body').on('click', '.btn-add-cart', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            $.ajax({
                type: "POST",
                url: '/Cart/AddToCart',
                data: {
                    id: id,
                    languageId: culture
                },
                success: function (res) {
                    $('#lbl_number_items_header').text(res.length.toString() + " sản phẩm");
                    loadData();
                },
                error: function (err) {
                    console.log(err);
                }
            });
        });
    }
    function loadData() {
        $.ajax({
            type: "GET",
            url: '/Cart/GetListItems',
            success: function (res) {
                var html = '';
                var total = 0;

                $.each(res, function (i, item) {
                    var amount = item.price * item.quantity;
                    var url = "/" + culture + "/san-pham/" + item.productId;
                    html += '<!--begin::Item-->' +
                        '<div class="d-flex align-items-center justify-content-between p-8">' +
                        '<div class="d-flex flex-column mr-2">' +
                        '<a href="' + url + '" class="font-weight-bold text-dark-75 font-size-lg text-hover-primary">' + item.name + '</a>' +
                        '<span class="text-muted">' + item.description + '</span>' +
                        '<div class="d-flex align-items-center mt-2">' +
                        '<span class="font-weight-bold mr-1 text-dark-75 font-size-lg">' + numberWithCommas(amount) + 'đ</span>' +
                        '<span class="text-muted mr-1">- SL</span>' +
                        '<span class="font-weight-bold mr-2 text-dark-75 font-size-lg">' + item.quantity + '</span>' +
                        '<a href="" class="btn btn-xs btn-light-success btn-icon mr-2">' +
                        '<i class="ki ki-minus icon-xs"></i>' +
                        '</a>' +
                        '<a href="#" class="btn btn-xs btn-light-success btn-icon">' +
                        '<i class="ki ki-plus icon-xs"></i>' +
                        '</a>' +
                        '</div>' +
                        '</div>' +
                        '<a href="' + url + '" class="symbol symbol-70 flex-shrink-0">' +
                        '<img src="' + $('#hidBaseAddress').val() + item.image + '" title="" alt="" />' +
                        '</a>' +
                        '</div>' +
                        '<!--end::Item-->' +
                        '<!--begin::Separator-->' +
                        '<div class="separator separator-solid"></div>' +
                        '<!--end::Separator-->';

                    total += amount;
                });

                $('#lbl_number_items_header').text(res.length.toString() + " sản phẩm");
                $('#cart_body').html(html);
                $('#lbl_total').text(numberWithCommas(total) + "đ");
                $('#lbl_subtotal').text(numberWithCommas(total) + "đ");
            }
        });
    }
    function loadCart() {
        $.ajax({
            type: "GET",
            url: '/Cart/GetListItems',
            success: function (res) {
                var html = '';
                var total = 0;

                $.each(res, function (i, item) {
                    var amount = item.price * item.quantity;
                    var url = "/" + culture + "/san-pham/" + item.productId;

                    html += '<tr>' +
                        '<td class="d-flex align-items-center font-weight-bolder">' +
                        '<!--begin::Symbol-->' +
                        '<div class="symbol symbol-60 flex-shrink-0 mr-4 bg-light">' +
                        '<div class="symbol-label" style="background-image: url(\'' + $('#hidBaseAddress').val() + item.image + '\')"></div>' +
                        '</div>' +
                        '<!--end::Symbol-->' +
                        '<a href="' + url + '" class="text-dark text-hover-primary">' + item.name + '</a>' +
                        '</td>' +
                        '<td class="text-center align-middle">' +
                        '<a href="javascript:;" class="btn btn-xs btn-light-success btn-icon mr-2">' +
                        '<i class="ki ki-minus icon-xs"></i>' +
                        '</a>' +
                        '<span class="mr-2 font-weight-bolder">' + item.quantity + '</span>' +
                        '<a href="javascript:;" class="btn btn-xs btn-light-success btn-icon">' +
                        '<i class="ki ki-plus icon-xs"></i>' +
                        '</a>' +
                        '</td>' +
                        '<td class="text-right align-middle font-weight-bolder font-size-h5">' + numberWithCommas(amount) + 'đ</td>' +
                        '<td class="text-right align-middle">' +
                        '<a href="#" class="btn btn-danger font-weight-bolder font-size-sm">Xoá</a>' +
                        '</td>' +
                        '</tr>';

                    total += amount;
                });

                $('#cart_content').html(html);
                $('#lbl_cart_subtotal').text(numberWithCommas(total) + "đ");
            }
        });
    }
}

function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".");
}