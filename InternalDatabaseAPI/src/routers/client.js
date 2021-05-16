const router = require("express").Router();
const Crud = require("../models/crud");
const execSQL = require("../db/db");
ClientCrud = new Crud("tblClient", "ClientID");
const findOneByUsername = async (username) => {
    const sql = `SELECT * FROM ${ClientCrud.tblName} WHERE ClientUserName='${username}'`
    console.log(sql)
    const data = await execSQL(sql); 
    return data;  
}
router.get("/db/Client/getClients",async(req,res,next)=>{
    try{
        res.send(await ClientCrud.readAll());  
    }catch (error){
        next(error);
    }
});

router.post("/db/Client/getClient",async(req,res, next)=>{
    //!Expects userid header inside post req
    try{
        const user = await ClientCrud.readOne(req.body.clientid);
        res.send(user.recordset[0]); 
    }catch (error){
        next(error);
    }  
});
router.post("/db/Client/getClient",async(req,res, next)=>{
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


router.post("/db/Client/updateUser",async(req,res,next)=>{
    try{
        res.send(await ClientCrud.updateOne(req.headers.userid, req.body.changes));
    }catch (error){
        next(error);
    }
});

module.exports = router;