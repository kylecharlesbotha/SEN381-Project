const axios = require("axios"); 
const getClientByID = async(ClientID) => {
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post("http://localhost:9999/db/Client/getClient", {clientid: ClientID}, config);
        return data; 
    }catch(error){
        console.log(error);
        return error;
    }
}
module.exports = getClientByID; 