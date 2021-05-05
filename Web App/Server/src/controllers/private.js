const getAllTickets = require("../models/Ticket");
const getPrivateData = (req,res,next) => {
    res.status(200).json({
        success: true, 
        data: "This is a private route for employees only."
    })
}

const getTickets = async(req,res,next) => {
    const tickets = await getAllTickets();
    res.status(200).json({
        success: true, 
        data: tickets
    })
}

module.exports = {getPrivateData, getTickets}