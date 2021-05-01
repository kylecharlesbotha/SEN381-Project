const router = new require("express").Router()
const Crud = require("../models/crud");
TicketCrud = new Crud("tblTicket", "TicketID");

router.get("/db/tickets/getTickets",async(req,res)=>{
    res.send(await TicketCrud.readAll());
})
router.post("/db/tickets/getTicket",async(req,res)=>{
    res.send(await TicketCrud.readOne(req.headers.ticketid)); 

})
router.post("/db/tickets/updateTicket",async(req,res)=>{
    res.send(await TicketCrud.updateOne(req.headers.ticketid, req.body.changes));
})

module.exports = router