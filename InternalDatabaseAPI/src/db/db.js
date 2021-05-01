const sql = require('mssql')
module.exports = async (sqlQuery) => {

const sqlConfig = {
  
  user: process.env.SQL_USERNAME,
  password: process.env.SQL_PASSWORD,
  database: process.env.DB_NAME,
  server: process.env.SERVER,
  pool: {
    max: 10,
    min: 0,
    idleTimeoutMillis: 30000
  },
  options: {
    encrypt: false, // for azure
    trustServerCertificate: false, // change to true for local dev / self-signed certs
    enableArithAbort: true
  }
}

try {
  await sql.connect(sqlConfig)
  const result = await sql.query(sqlQuery);
  return result; 
 } catch (err) {
  throw new Error("DB ERROR");
}
}