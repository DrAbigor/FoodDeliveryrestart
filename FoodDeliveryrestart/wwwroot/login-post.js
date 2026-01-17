function submitLoginForm(email, password) {
    // Create a form and submit it to /auth/login
    const form = document.createElement('form');
    form.method = 'POST';
    form.action = '/auth/login';

    const inputEmail = document.createElement('input');
    inputEmail.type = 'hidden';
    inputEmail.name = 'Email';
    inputEmail.value = email;
    form.appendChild(inputEmail);

    const inputPassword = document.createElement('input');
    inputPassword.type = 'hidden';
    inputPassword.name = 'Password';
    inputPassword.value = password;
    form.appendChild(inputPassword);

    document.body.appendChild(form);
    form.submit();
}

window.submitLoginForm = submitLoginForm;
