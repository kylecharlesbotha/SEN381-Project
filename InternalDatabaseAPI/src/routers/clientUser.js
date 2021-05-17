const router = require("express").Router();
const Crud = require("../models/crud");
const execSQL = require("../db/db");
ClientUserCrud = new Crud("tblClientUsers", "ClientID");
const findOneByUsername = async (username) => {
    const sql = `SELECT * FROM ${ClientUserCrud.tblName} WHERE ClientUserName='${username}'`
    console.log(sql)
    const data = await execSQL(sql); 
    return data;  
}
router.post("/db/ClientUsers/setPassword", async (req,res,next) => {
    try{
        const sql = `UPDATE tblClientUsers SET ClientPassWord='${req.body.password}' WHERE ClientUserName='${req.body.username}'`;
        console.log(sql);
        const data = await execSQL(sql);
        
        console.dir(data);
        res.send(data); 
    }catch (error){
        next(error);
    }  
})
const findOneByPasswordResetToken = async (token) => {
    const sql = `SELECT * FROM ${ClientUserCrud.tblName} WHERE ClientPasswordResetToken='${token}'`
    console.log(sql)
    const data = await execSQL(sql); 
    return data;  
}
router.post("/db/ClientUsers/getUserByPasswordResetToken", async (req,res,next) => {
    try{
        const user = await findOneByPasswordResetToken(req.body.PasswordResetToken);
        console.dir(user)
        res.send(user.recordset[0]); 
    }catch (error){
        next(error);
    }  
})
router.get("/db/ClientUsers/getUsers",async(req,res,next)=>{
    try{
        res.send(await ClientUserCrud.readAll());  
    }catch (error){
        next(error);
    }
});

router.post("/db/ClientUsers/getUser",async(req,res, next)=>{
    //!Expects userid header inside post req
    try{
        const user = await ClientUserCrud.readOne(req.body.clientid);
        res.send(user.recordset[0]); 
    }catch (error){
        next(error);
    }  
});
router.post("/db/ClientUsers/getUserByUsername",async(req,res, next)=>{
    //!Expects userid header inside post req
    try{
        //console.log(req.body.UserName)
        
        const user = await findOneByUsername(req.body.UserName);
        console.dir(user)
        res.send(user.recordset[0]); 
    }catch (error){
        next(error);
    }  
});
router.post("/db/ClientUsers/saveUserToken",async(req,res, next)=>{
    try{
        console.dir(req.body)
        const sql = `UPDATE tblClientUsers SET ClientPasswordResetToken='${req.body.PasswordResetToken}' WHERE ClientUserName='${req.body.UserName}'`;
        const data = await execSQL(sql);
        console.log(sql)
        console.dir(data);
        res.send(data); 
    }catch (error){
        next(error);
    }  
});

router.post("/db/ClientUsers/updateUser",async(req,res,next)=>{
    try{
        res.send(await ClientUserCrud.updateOne(req.headers.userid, req.body.changes));
    }catch (error){
        next(error);
    }
});

module.exports = router;