const router = require("express").Router();
const { NText } = require("mssql");
const Crud = require("../models/crud");
UserCrud = new Crud("tblUser", "UserID");
router.get("/db/users/getUsers",async(req,res,next)=>{
    try{
        res.send(await UserCrud.readAll());  
    }catch (error){
        next(error);
    }
});

router.post("/db/users/getUser",async(req,res, next)=>{
    //!Expects userid header inside post req
    try{
        res.send(await UserCrud.readOne(req.headers.userid)); 
    }catch (error){
        next(error);
    }  
});

router.post("/db/users/updateUser",async(req,res,next)=>{
    try{
        res.send(await UserCrud.updateOne(req.headers.userid, req.body.changes));
    }catch (error){
        next(error);
    }
});

module.exports = router;