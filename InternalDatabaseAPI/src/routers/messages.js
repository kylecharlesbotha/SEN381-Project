
const router = new require("express").Router()
const Crud = require("../models/crud");
MessageCRUD = new Crud("tblMessage", "MessageID");
router.get("/db/messages/getMessages",async(req,res)=>{
    res.send(await MessageCRUD.readAll());
})
router.post("/db/messages/getMessage",async(req,res)=>{
    res.send(await MessageCRUD.readOne(req.headers.messageid)); 
})
router.post("/db/messages/updateMessage",async(req,res)=>{
    res.send(await MessageCRUD.updateOne(req.headers.messageid, req.body.changes));
})

module.exports = router