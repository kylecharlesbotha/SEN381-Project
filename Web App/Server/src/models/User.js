const axios = require("axios");
const bcrypt = require("bcryptjs");
const jwt = require("jsonwebtoken");
class User{
    // #username_ = null; 
    // #password_ = null;
    constructor(UserObj){
        this.UserObj = UserObj;
    }
    
    // getUsername(){
    //     return this.#username_; 
    // }
    // getPassword(){
    //     return this.#password_;
    // }
    // setUsername(username){
    //     this.#username_ = username; 
    // }
    // setPassword(password){
    //     this.#password_ = password; 
    // }
    Create(userObj){
        //!Create user in db from here.
    }
    
    async matchPasswords(password){
        
        return await bcrypt.compare(password, this.UserObj.UserPassword); 
    } 
    getSignedToken(){
        return jwt.sign({id: this.UserObj.UserID}, process.env.JWT_SECRET);
    }
}
const findOne = async(username) => {
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
        next(error);
    }
}
const findById = async(id) => {
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
module.exports = {User, findOne, findById}; 