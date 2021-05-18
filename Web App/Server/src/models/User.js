const axios = require("axios");
const bcrypt = require("bcryptjs");
const crypto = require("crypto"); 
const jwt = require("jsonwebtoken");
class User{
    constructor(UserObj){
        this.UserObj = UserObj;
    }
    
    Create(userObj){
        //!Create user in db from here.
    }
    
    async matchPasswords(password){
        return await bcrypt.compare(password, this.UserObj.UserPassword); 
    } 
    async matchClientPasswords(password){
        return await bcrypt.compare(password, this.UserObj.ClientPassWord); 
    } 
    getSignedToken(){
        console.dir(this.UserObj);
        return jwt.sign({id: this.UserObj.UserID}, process.env.JWT_SECRET);
    }
    getSignedTokenForClient(){
        console.dir(this.UserObj);
        return jwt.sign({id: this.UserObj.ClientID}, process.env.JWT_SECRET);
    }

    async getResetPasswordToken(){
        
        const resetToken = crypto.randomBytes(20).toString("hex");
        this.UserObj.resetPasswordToken = crypto.createHash("sha256").update(resetToken).digest("hex"); 
        try{
            let result = await saveEmployeePasswordResetToken(this.UserObj.UserName,this.UserObj.resetPasswordToken);
            console.log(typeof(result.rowsAffected[0]))
            if (result.rowsAffected[0] > 1){
                return resetToken;
            }
            
            console.dir(this.UserObj);
            console.log(this.UserObj.resetPasswordToken, resetToken);
            saveClientPasswordResetToken(this.UserObj.ClientUserName,this.UserObj.resetPasswordToken);
            return resetToken;
        }catch{

        }

        
    }

}
const saveEmployeePasswordResetToken = async(username, token) => {
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post(
            "http://localhost:9999/db/EmployeeUsers/saveUserToken",
            { UserName: username, PasswordResetToken:token},
            config,
        );
        return data; 
    }catch(error){
        console.log(error);
        return error;
    }
}
const saveClientPasswordResetToken = async(username, token) => {
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post(
            "http://localhost:9999/db/ClientUsers/saveUserToken",
            { UserName: username, PasswordResetToken:token},
            config,
        );
        return data; 
    }catch(error){
        console.log(error);
        return error;
    }
}
const findOneByPasswordResetToken = async(token) => {
    let user = null;
    const resultFromClient = await findOneClientByPRT(token); 
    const resultFromEmployee = await findOneEmployeeByPRT(token); 
    if (resultFromClient.length != undefined || resultFromClient.length === 0 ){
        user = resultFromEmployee
    }else{
        user = resultFromClient; 
    }
    return user; 
}
const setPassword = async (username, password) => {
    console.log("still working")
    let user = null;
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    
    const resultFromClient = await findOneClient(username); 
    const resultFromEmployee = await findOneEmployee(username); 
    const salt = await bcrypt.genSalt(8); 
    let pwd = await bcrypt.hash(password, salt);
       
    
    
    
   
    if (resultFromClient.length != undefined || resultFromClient.length === 0 ){
        try{
        console.log("EMP")

            const { data } = await axios.post(
                "http://localhost:9999/db/EmployeeUsers/setPassword",
                { username, password:pwd },
                config,
            );
            console.log("still going")
            return data; 
        }catch(error){
            console.log(error);
            return error;
        }
    }else{
        console.log("client")
        try{
            const { data } = await axios.post(
                "http://localhost:9999/db/ClientUsers/setPassword",
                { username, password:pwd },
                config,
            );
            console.log("still going")
            return data; 
        }catch(error){
            console.log(error);
            return error;
        }
    }
    return user; 
}
const findOneEmployeeByPRT = async(token) => {
    console.log(`Finding employee with token ${token}`); 
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post(
            "http://localhost:9999/db/EmployeeUsers/getUserByPasswordResetToken",
            { PasswordResetToken: token },
            config,
        );
        return data; 
    }catch(error){
        console.log(error);
        return error;
    }
}
const findOneClientByPRT = async(token) => {
    console.log(`Finding client with toekn ${token}`); 
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post(
            "http://localhost:9999/db/ClientUsers/getUserByPasswordResetToken",
            { PasswordResetToken: token },
            config,
        );
        return data; 
    }catch(error){
        console.log(error);
        return error;
    }
}
const findOneEmployee = async(username) => {
    console.log(`Finding user with username ${username}`); 
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post(
            "http://localhost:9999/db/EmployeeUsers/getUserByUsername",
            { UserName: username },
            config,
        );
        return data; 
    }catch(error){
        console.log(error);
        return error;
    }
}
const findOneClient = async(username) => {
    console.log(`Finding user with username ${username}`); 
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post(
            "http://localhost:9999/db/ClientUsers/getUserByUsername",
            { UserName: username },
            config,
        );
        console.log(username);
        return data; 
    }catch(error){
        console.log(error);
        return error;
    }
}
const findEmployeeById = async(id) => {
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post(
            "http://localhost:9999/db/EmployeeUsers/getUser",
            { UserID: id },
            config,
        );
        return data; 
    }catch(error){
        console.log(error);
        next(error);
    }
}
const findClientById = async(id) => {
     
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post(
            "http://localhost:9999/db/clientUsers/getUser",
            { ClientID: id },
            config,
        );
         
        return data; 
    }catch(error){
        console.log("find client err: " + error);
        next(error);
    }
}
const findClientEmailByID = async(id) => {
    console.log(id); 
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post(
            "http://localhost:9999/db/clientUsers/getEmail",
            { ClientID: id },
            config,
        ); 
        return data.recordset[0].ClientEmail; 
    }catch(error){
        console.log("find client err: " + error);
        next(error);
    }
}
module.exports = {User, findOneEmployee, findOneClient, findEmployeeById, findClientById, findOneByPasswordResetToken, setPassword, findClientEmailByID}; 