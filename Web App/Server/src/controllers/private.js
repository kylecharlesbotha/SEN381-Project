const {getAllTickets, getTicketByID} = require("../models/Ticket");
const {getAllSatisfactions,addOneSatisfaction} = require("../models/Satisfaction");
const getClientByID = require("./../models/Client");
const getPrivateEmployeeData = (req,res,next) => {
    res.status(200).json({
        success: true, 
        data: "This is a private route for employees only."
    })
}
const getPrivateClientData = (req,res,next) => {
    res.status(200).json({
        success: true, 
        data: "This is a private route for clients only."
    })
}
const getTickets = async(req,res,next) => {
    const tickets = await getAllTickets();
    res.status(200).json({
        success: true, 
        data: tickets
    })
}
const getTicket = async(req,res,next) => {
    
    const ticket = await getTicketByID(req.body.TicketID);
    res.status(200).json({
        success: true, 
        data: ticket
    })
}
const getSatisfactions = async(req,res,next) => {
    const satisfactions = await getAllSatisfactions();
    res.status(200).json({
        success: true, 
        data: satisfactions
    })
}
const getClient = async(req,res,next) => {
    console.log(req.body.ClientID)
    const client = await getClientByID(req.body.ClientID);
    console.dir(client)
    res.status(200).json({
        success: true, 
        data: client
    })
}
const addSatisfactions = async(req,res,next) => {
    const satisfaction = await addOneSatisfaction(req.body.satisfaction);
    res.status(200).json({
        success: true, 
        data: satisfaction
    })
}

module.exports = {getPrivateEmployeeData, getPrivateClientData, getTickets, getTicket, getSatisfactions, getClient, addSatisfactions}