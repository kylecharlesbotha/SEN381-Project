const router = new require("express").Router()
const Crud = require("../models/crud");
TicketCrud = new Crud("tblTicket", "TicketID");
const execSQL = require("../db/db");
router.get("/db/tickets/getTickets",async(req,res,next)=>{
    try{
        res.send(await TicketCrud.readAll());
    }catch (error){
        next(error);
    }
    
})
router.post("/db/tickets/getTicket",async(req,res,next)=>{  
    try{
        res.send(await TicketCrud.readOne(req.body.ticketid)); 
    }catch (error){
        next(error);
    }
})
router.post("/db/tickets/updateTicket",async(req,res,next)=>{
    try{
        res.send(await TicketCrud.updateOne(req.headers.ticketid, req.body.changes));
    }catch (error){
        next(error);
    }
})
router.post("/db/tickets/getClientTickets",async(req,res,next)=>{
    const sql = `SELECT * FROM tblTicket WHERE ClientID='${req.body.ClientID}'`
    console.log(sql);
    const data = await execSQL(sql);
     
    res.send(data.recordset);
})
module.exports = router