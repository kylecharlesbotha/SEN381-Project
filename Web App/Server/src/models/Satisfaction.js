const axios = require("axios"); 
const getAllSatisfactions = async() => {
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.get("http://localhost:9999/db/satisfaction/getSatisfactions", config);
        return data; 
    }catch(error){
        console.log(error);
        return error;
    }
}
const addOneSatisfaction = async(obj) => {
    console.dir(obj)
    const config = {
        header: {
            "Content-Type": "application/json",
        },
    };
    try{
        const { data } = await axios.post("http://localhost:9999/db/satisfaction/insertSatisfaction",obj, config);
        return data; 
    }catch(error){
        //console.log(error);
        return error;
    }
}
module.exports = {getAllSatisfactions, addOneSatisfaction}; 