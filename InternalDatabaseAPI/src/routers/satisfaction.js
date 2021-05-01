const router = require("express").Router();
const Crud = require("../models/crud");
SatisfactionCrud = new Crud("tblSatisfaction", "SatisfactionID");
router.get("/db/satisfaction/getSatisfactions",async(req,res)=>{
    res.send(await SatisfactionCrud.readAll());  
})
router.post("/db/satisfaction/getSatisfaction",async(req,res)=>{
    //!Expects userid header inside post req
    res.send(await SatisfactionCrud.readOne(req.headers.userid));  
})
router.post("/db/satisfaction/updateSatisfaction",async(req,res)=>{
    res.send(await SatisfactionCrud.updateOne(req.headers.userid, req.body.changes));
})

module.exports = router;