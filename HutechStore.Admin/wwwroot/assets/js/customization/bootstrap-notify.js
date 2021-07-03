"use strict";

const states = {
    success: "success",
    danger: "danger",
    warning: "warning",
    info: "info",
    primary: "primary",
    dark: "dark"
};

const placementFroms = {
    top: "top",
    bottom: "bottom"
};

const placementAligns = {
    left: "left",
    right: "right",
    center: "center"
}

const animates = {
    bounce: "bounce"
}

// basic demo
function pushBootstrapNotify(
    message,
    title,
    icon,
    url,
    state = states.success,
    allowDismiss = true,
    newestOnTop = true,
    pauseOnHover = false,
    showProgressbar = false,
    spacing = 10,
    timer = 2000,
    placementFrom = placementFroms.bottom,
    placementAlign = placementAligns.right,
    offsetX = 30,
    offsetY = 30,
    delay = 1000,
    zIndex = 10000,
    animateEnter = animates.bounce,
    animateExit = animates.bounce,
    notifyProgress = false
) {
    var content = {};

    content.message = message;
    if (title) {
        content.title = title;
    }
    if (icon) {
        content.icon = 'icon ' + icon;
    }
    if (url) {
        content.url = url;
        content.target = '_blank';
    }

    var notify = $.notify(content, {
        type: state,
        allow_dismiss: allowDismiss,
        newest_on_top: newestOnTop,
        mouse_over: pauseOnHover,
        showProgressbar: showProgressbar,
        spacing: spacing,
        timer: timer,
        placement: {
            from: placementFrom,
            align: placementAlign
        },
        offset: {
            x: offsetX,
            y: offsetY
        },
        delay: delay,
        z_index: zIndex,
        animate: {
            enter: 'animate__animated animate__' + animateEnter,
            exit: 'animate__animated animate__' + animateExit
        }
    });

    if (notifyProgress) {
        setTimeout(function () {
            notify.update('message', '<strong>Saving</strong> Page Data.');
            notify.update('type', 'primary');
            notify.update('progress', 20);
        }, 1000);

        setTimeout(function () {
            notify.update('message', '<strong>Saving</strong> User Data.');
            notify.update('type', 'warning');
            notify.update('progress', 40);
        }, 2000);

        setTimeout(function () {
            notify.update('message', '<strong>Saving</strong> Profile Data.');
            notify.update('type', 'danger');
            notify.update('progress', 65);
        }, 3000);

        setTimeout(function () {
            notify.update('message', '<strong>Checking</strong> for errors.');
            notify.update('type', 'success');
            notify.update('progress', 100);
        }, 4000);
    }
}