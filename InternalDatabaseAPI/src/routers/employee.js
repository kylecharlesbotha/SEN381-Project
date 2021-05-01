const router = new require("express").Router()
const Crud = require("../models/crud");
EmployeeCRUD = new Crud("tblEmployee", "EmployeeID");
router.get("/db/employees/getEmployees",async(req,res)=>{
    res.send(await EmployeeCRUD.readAll());
})
router.post("/db/employees/getEmployee",async(req,res)=>{
    res.send(await EmployeeCRUD.readOne(req.headers.messageid)); 
})
router.post("/db/employees/updateEmployee",async(req,res)=>{
    res.send(await EmployeeCRUD.updateOne(req.headers.messageid, req.body.changes));
})

module.exports = router