const express = require("express"); 
const router = express.Router(); 
const {getPrivateData, getTickets} = require("../controllers/private"); 
const {protect} = require("../middleware/auth");
router.route("/").get(protect,getPrivateData); 
router.route("/data/tickets").get(protect,getTickets); 
module.exports = router;