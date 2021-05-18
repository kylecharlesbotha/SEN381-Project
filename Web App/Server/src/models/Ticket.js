const axios = require("axios"); 
const getAllTickets = async() => {
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.get("http://localhost:9999/db/tickets/getTickets", config);
        return data; 
    }catch(error){
        console.log(error);
        return error;
    }
}
const getTicketByID = async(TicketID) => {
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post("http://localhost:9999/db/tickets/getTicket",{ticketid:TicketID}, config);
        return data; 
    }catch(error){
        console.log(error);
        return error;
    } 
}
const findTicketsByClientID = async(ClientID) => {
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        console.log("halo")
        const { data } = await axios.post("http://localhost:9999/db/tickets/getClientTickets",{ClientID}, config);
        
        console.dir(data)
        return data; 
    }catch(error){
        console.log(error);
        return error;
    } 
}
module.exports = {getAllTickets, getTicketByID, findTicketsByClientID}; 