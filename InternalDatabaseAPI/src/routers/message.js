
const router = new require("express").Router()
const { NText } = require("mssql");
const Crud = require("../models/crud");
MessageCRUD = new Crud("tblMessage", "MessageID");
router.get("/db/messages/getMessages",async(req,res,next)=>{
    try{
        res.send(await MessageCRUD.readAll());
    }catch(error){
        next(error);
    }
})
router.post("/db/messages/getMessage",async(req,res,next)=>{
    try{
        res.send(await MessageCRUD.readOne(req.headers.messageid)); 
    }catch(error){
        next(error);
    }
})
router.post("/db/messages/updateMessage",async(req,res,next)=>{
    try{
        res.send(await MessageCRUD.updateOne(req.headers.messageid, req.body.changes));
    }catch(error){
        next(error);
    }  
})

module.exports = router