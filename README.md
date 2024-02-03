# WebReklamm

#Login and Register Wiev

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styles.css">
    <title>Login and Register Popup</title>
</head>
<body>

<!-- Login and Register Buttons -->
<div class="popup-buttons">
    <button onclick="openLoginPopup()">Login</button>
    <button onclick="openRegisterPopup()">Register</button>
</div>

<!-- Login Popup -->
<div id="loginPopup" class="popup">
    <span class="close" onclick="closeLoginPopup()">&times;</span>
    <h2>Login</h2>
    <!-- Your login form here -->
</div>

<!-- Register Popup -->
<div id="registerPopup" class="popup">
    <span class="close" onclick="closeRegisterPopup()">&times;</span>
    <h2>Register</h2>
    <!-- Your register form here -->
</div>

<script src="script.js"></script>
</body>
</html>
Style.css :
body {
    font-family: Arial, sans-serif;
}

.popup {
    display: none;
    position: fixed;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    padding: 20px;
    background-color: #fff;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    z-index: 1;
}

.popup h2 {
    margin-top: 0;
}

.popup-buttons {
    text-align: center;
    margin-top: 20px;
}

.close {
    position: absolute;
    top: 10px;
    right: 10px;
    cursor: pointer;
}
Style.js : 
function openLoginPopup() {
    document.getElementById("loginPopup").style.display = "block";
}

function closeLoginPopup() {
    document.getElementById("loginPopup").style.display = "none";
}

function openRegisterPopup() {
    document.getElementById("registerPopup").style.display = "block";
}

function closeRegisterPopup() {
    document.getElementById("registerPopup").style.display = "none";
}

// Close popups if user clicks outside the popup
window.onclick = function (event) {
    if (event.target.classList.contains("popup")) {
        event.target.style.display = "none";
    }
};
