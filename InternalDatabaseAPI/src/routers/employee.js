const router = new require("express").Router()
const Crud = require("../models/crud");
EmployeeCRUD = new Crud("tblEmployee", "EmployeeID");
router.get("/db/employees/getEmployees",async(req,res,next)=>{
    try{
        res.send(await EmployeeCRUD.readAll());
    }catch(error){
        next(error);
    }    
})
router.post("/db/employees/getEmployee",async(req,res)=>{
    try{
        res.send(await EmployeeCRUD.readOne(req.headers.messageid));
    }catch(error){
        next(error);
    }
})
router.post("/db/employees/updateEmployee",async(req,res)=>{
    try{
        res.send(await EmployeeCRUD.updateOne(req.headers.messageid, req.body.changes));
    }catch(error){
        next(error);
    }
})

module.exports = router