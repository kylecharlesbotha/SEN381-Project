
const router = new require("express").Router()
const Crud = require("../models/crud");
RoomCrud = new Crud("tblRoom", "RoomID");     
router.get("/db/rooms/getRooms",async(req,res)=>{
    res.send(await RoomCrud.readAll());
})
router.post("/db/rooms/getRoom",async(req,res)=>{
    res.send(await RoomCrud.readOne(req.headers.roomid)); 
})
router.post("/db/rooms/updateRoom",async(req,res)=>{
    res.send(await RoomCrud.updateOne(req.headers.roomid, req.body.changes));
})

module.exports = router