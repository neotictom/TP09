const caracteresEspeciales = ['!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '{', '}', '[', ']', ':', ';', '"', "'", '<', '>', ',', '.', '/', '\\', '|', '?', '~', '`', '¡', '¿'];

function ValidarRegistro() {
    var password1 = null;
    var password2 = null;
    var telefono = null;
    let contieneCaracterEspecial = false;

    password1 = document.getElementById("PasswordRegistro1").value;
    password2 = document.getElementById("PasswordRegistro2").value;

    for (let i = 0; i < caracteresEspeciales.length; i++) {
        if (password1.includes(caracteresEspeciales[i])) { contieneCaracterEspecial = true; }
    }

    if (password1 == password2 && password1.length >= 8 && contieneCaracterEspecial && password1 != password1.toLowerCase()) {
        return true;
    } else {
        return false;
    }
}

function ValidarPassword1() {
    let aviso = document.getElementById("avisoErrorRegistro");
    let password1 = document.getElementById("PasswordRegistro1").value;
    let passwordInput1 = document.getElementById("PasswordRegistro1");
    let contieneCaracterEspecial = false;

    for (let i = 0; i < caracteresEspeciales.length; i++) {
        if (password1.includes(caracteresEspeciales[i])) {
            contieneCaracterEspecial = true;
        }
    }

    if (password1.length < 8) {
        aviso.innerText = "La contraseña debe tener al menos 8 caracteres.";
        passwordInput1.classList.add("InputMal");
        passwordInput1.classList.remove("InputBien");
    } else if (!contieneCaracterEspecial) {
        aviso.innerText = "La contraseña debe incluir al menos un caracter especial.";
        passwordInput1.classList.add("InputMal");
        passwordInput1.classList.remove("InputBien");
    } else if (password1 === password1.toLowerCase()) {
        aviso.innerText = "La contraseña debe contener al menos una letra mayúscula.";
        passwordInput1.classList.add("InputMal");
        passwordInput1.classList.remove("InputBien");
    } else {
        aviso.innerText = "";
        passwordInput1.classList.add("InputBien");
        passwordInput1.classList.remove("InputMal");
    }
}

function ValidarPassword2() {
    let password1 = document.getElementById("PasswordRegistro1").value;
    let password2 = document.getElementById("PasswordRegistro2").value;
    let passwordInput2 = document.getElementById("PasswordRegistro2");

    if (password2 === password1) {
        passwordInput2.classList.add("InputBien");
        passwordInput2.classList.remove("InputMal");
    } else {
        passwordInput2.classList.add("InputMal");
        passwordInput2.classList.remove("InputBien");
    }
}

function ValidarModificacion() {
    var password1 = null;
    var password2 = null;
    var telefono = null;
    let contieneCaracterEspecial = false;

    password1 = document.getElementById("PasswordModificar1").value;
    password2 = document.getElementById("PasswordModificar2").value;

    for (let i = 0; i < caracteresEspeciales.length; i++) {
        if (password1.includes(caracteresEspeciales[i])) { contieneCaracterEspecial = true; }
    }

    if (password1 == password2 && password1.length >= 8 && contieneCaracterEspecial && password1 != password1.toLowerCase()) {
        console.log("bien");
        return true;
    } else {
        console.log("mal");
        return false;
    }
}

