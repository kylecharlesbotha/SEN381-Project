const router = require("express").Router();
const Crud = require("../models/crud");
SatisfactionCrud = new Crud("tblSatisfaction", "SatisfactionID");
router.get("/db/satisfaction/getSatisfactions",async(req,res,next)=>{
    try{
        
        res.send(await SatisfactionCrud.readAll()); 
    }catch (error){
        next(error);
    }
})
router.post("/db/satisfaction/getSatisfaction",async(req,res,next)=>{
    //!Expects userid header inside post req
    try{
        res.send(await SatisfactionCrud.readOne(req.headers.userid));
    }catch (error){
        next(error);
    }
      
})
router.post("/db/satisfaction/updateSatisfaction",async(req,res,next)=>{
    try{
        res.send(await SatisfactionCrud.updateOne(req.headers.userid, req.body.changes));
    }catch (error){
        next(error);
    }
    
})
router.post("/db/satisfaction/insertSatisfaction",async(req,res,next)=>{
    try{
        const satisfaction = req.body; 
        // console.dir(satisfaction)
        res.send(await SatisfactionCrud.insertOne(satisfaction));
    }catch (error){
        next(error);
    }
    
})


module.exports = router;