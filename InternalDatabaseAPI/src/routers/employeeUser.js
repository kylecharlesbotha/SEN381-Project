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
const findOneByPasswordResetToken = async (token) => {
    const sql = `SELECT * FROM ${EmployeeUserCrud.tblName} WHERE UserPasswordResetToken='${token}'`
    console.log(sql)
    const data = await execSQL(sql); 
    return data;  
}
router.post("/db/EmployeeUsers/setPassword", async (req,res,next) => {
    try{
        const data = await execSQL(`UPDATE tblEmployeeUser SET UserPassword='${req.body.password}' WHERE UserName='${req.body.username}'`);
        console.dir(data);
        res.send(data); 
    }catch (error){
        next(error);
    }  
})
router.post("/db/EmployeeUsers/getUserByPasswordResetToken", async (req,res,next) => {
    try{
        const user = await findOneByPasswordResetToken(req.body.PasswordResetToken);
        console.dir(user)
        res.send(user.recordset[0]); 
    }catch (error){
        next(error);
    }  
})
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
router.post("/db/EmployeeUsers/saveUserToken",async(req,res, next)=>{
     
    try{
        console.log(req.body.UserName);
        const data = await execSQL(`UPDATE tblEmployeeUser SET UserPasswordResetToken='${req.body.PasswordResetToken}' WHERE UserName='${req.body.UserName}'`);
        console.dir(data);
        res.send(data); 
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