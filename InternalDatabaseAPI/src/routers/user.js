const router = require("express").Router();
const { NText } = require("mssql");
const Crud = require("../models/crud");
const execSQL = require("../db/db");
UserCrud = new Crud("tblUser", "UserID");
const findOneByUsername = async (username) => {
    const sql = `SELECT * FROM tblEmployeeUser WHERE UserName='${username}'`
    const data = await execSQL(sql); 
    return data;  
}
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
router.post("/db/users/getUserByUsername",async(req,res, next)=>{
    //!Expects userid header inside post req
    try{
        const user = await findOneByUsername(req.body.username);
        res.send(user.recordset[0]); 
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