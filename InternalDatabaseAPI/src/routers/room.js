
const router = new require("express").Router()
const Crud = require("../models/crud");
RoomCrud = new Crud("tblRoom", "RoomID");     
router.get("/db/rooms/getRooms",async(req,res,next)=>{
    try{
        res.send(await RoomCrud.readAll());
    }catch(error){
        next(error); 
    }
})
router.post("/db/rooms/getRoom",async(req,res,next)=>{
    try{
        res.send(await RoomCrud.readOne(req.headers.roomid)); 
    }catch(error){
        next(error); 
    }
})
router.post("/db/rooms/updateRoom",async(req,res,next)=>{
    try{
        res.send(await RoomCrud.updateOne(req.headers.roomid, req.body.changes));
    }catch(error){
        next(error); 
    }
})

module.exports = router