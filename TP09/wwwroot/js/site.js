function validarContraseña() {
    var contraseña = document.getElementById("password").value;
    var regex = /^(?=.*[A-Z])(?=.*[!@#$%^&*])(.{8,})$/;
    if (!regex.test(contraseña)) {
        alert("La contraseña debe tener al menos 8 caracteres, una letra en mayúscula y un carácter especial (!@#$%^&*).");
        return false;
    }
    return true;
}
