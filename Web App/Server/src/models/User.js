const axios = require("axios");
const bcrypt = require("bcryptjs");
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
        return jwt.sign({id: this.UserObj.UserID}, process.env.JWT_SECRET);
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
        console.log(error);
        next(error);
    }
}
module.exports = {User, findOneEmployee, findOneClient, findEmployeeById, findClientById}; 