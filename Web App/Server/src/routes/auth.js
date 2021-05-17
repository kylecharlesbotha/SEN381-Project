const express = require('express');
const router = express.Router(); 

const {register, loginEmployee,loginClient, forgotpassword, resetpassword} = require('../controllers/auth');

//router.route("/register").post(register);//for later use...
router.route("/loginEmployee").post(loginEmployee);
router.route("/loginClient").post(loginClient);
router.route("/forgotpassword").post(forgotpassword);
//router.route("/resetpassword/:resetToken").post(resetpassword);

module.exports = router; 