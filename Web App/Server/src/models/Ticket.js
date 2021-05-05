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
module.exports = getAllTickets; 