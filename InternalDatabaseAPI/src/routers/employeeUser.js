const router = require("express").Router();
const Crud = require("../models/crud");
const execSQL = require("../db/db");
EmployeeUserCrud = new Crud("tblEmployeeUser", "UserID");
const findOneByUsername = async (username) => {
    const sql = `SELECT * FROM ${EmployeeUserCrud.tblName} WHERE UserName='${username}'`
    console.log(sql)
    const data = await execSQL(sql); 
    return data;  
}
router.get("/db/EmployeeUsers/getUsers",async(req,res,next)=>{
    try{
        res.send(await EmployeeUserCrud.readAll());  
    }catch (error){
        next(error);
    }
});

router.post("/db/EmployeeUsers/getUser",async(req,res, next)=>{
    //!Expects userid header inside post req
    try{
        const user = await EmployeeUserCrud.readOne(req.body.UserID);
        res.send(user.recordset[0]); 
    }catch (error){
        next(error);
    }  
});
router.post("/db/EmployeeUsers/getUserByUsername",async(req,res, next)=>{
    //!Expects userid header inside post req
    try{
        console.log(req.body.UserName)

        const user = await findOneByUsername(req.body.UserName);
        
        res.send(user.recordset[0]); 
    }catch (error){
        next(error);
    }  
});


router.post("/db/EmployeeUsers/updateUser",async(req,res,next)=>{
    try{
        res.send(await EmployeeUserCrud.updateOne(req.headers.userid, req.body.changes));
    }catch (error){
        next(error);
    }
});

module.exports = router;