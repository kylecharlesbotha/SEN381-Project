const execSQL = require("../db/db");
module.exports = class Crud {
    constructor(tblName,filter = "",filterValue = ""){
        this.tblName = tblName;
        this.filter = filter; 
        this.filterValue = this.filterValue;
    }
    setFilter(filterValue){
        this.filterValue = filterValue; 
    }
    getFilter(){
        return this.filter; 
    }
    getTblName(){
        return this.tblName
    }
    async readAll(){
        const sql = `SELECT * FROM ${this.tblName}`;  
        const data = await execSQL(sql);
        return data; 
    }
    async readOne(objID){
        const sql = `SELECT * FROM ${this.tblName} WHERE ${this.filter}='${objID}'`
        const data = await execSQL(sql); 
        return data;  
    }
    async updateOne(objID,objReplace){  
        var objOld = await this.readOne(objID);
        objOld = objOld.recordset[0];
        Object.entries(objOld).forEach(
            ([key, value]) => objReplace.hasOwnProperty(key) ? objOld[key] = objReplace[key] : value = value
        );
        let sql = ""; 
        sql += `UPDATE ${this.tblName} SET `; 
        Object.entries(objOld).slice(1).forEach(
            ([key, value]) => sql += `${key}='${value}',`
        );      
        sql = sql.slice(0, -1);
        sql += ` WHERE ${this.filter}=${objOld.UserID}`;
        const data = await execSQL(sql);
        return data;
    }
}