const jwt = require("jsonwebtoken"); 
const {findById} = require("../models/User");
const ErrorResponse = require('../utils/errorResponse');
exports.protect = async (req, res, next) => {
    let token; 
    
    if(req.headers.authorization && req.headers.authorization.startsWith("Bearer")){
        token = req.headers.authorization.split(" ")[1]; 
    }
     
    if (!token){
        return next(new ErrorResponse("Not authorized", 401)); 
    }
    try{
        const decoded = await jwt.verify(token, process.env.JWT_SECRET);
        
        const user = await findById(decoded.id);
        
        if (!user){
            return next(new ErrorResponse("Invalid user token", 404)); 
        }
        req.user = user; 
            
        next();
    }catch(error){ 
        return next(new ErrorResponse("Unauthorized", 401)); 
    }
};