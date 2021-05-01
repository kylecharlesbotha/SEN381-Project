const router = require("express").Router();
const Crud = require("../models/crud");
UserCrud = new Crud("tblUser", "UserID");
router.get("/db/users/getUsers",async(req,res)=>{
    res.send(await UserCrud.readAll());  
})
router.post("/db/users/getUser",async(req,res)=>{
    //!Expects userid header inside post req
    res.send(await UserCrud.readOne(req.headers.userid));  
})
router.post("/db/users/updateUser",async(req,res)=>{
    res.send(await UserCrud.updateOne(req.headers.userid, req.body.changes));
})

module.exports = router;