var Connection = require('tedious').Connection;
var Request = require('tedious').Request;
module.exports = (sqlStatement) => {
    var config = {
        server: process.env.SERVER_HOSTNAME,
        authentication: {
          type: 'default',
          options: {
            userName: process.env.SQL_USERNAME,
            password: process.env.SQL_PASSWORD
          }
        },
        options: {
          trustServerCertificate: true,
          database: process.env.DB_NAME
        }
      };
      
      const connection = new Connection(config);
      
      connection.on('connect', (err) => {
        if (err) {
          console.log('Connection Failed');
          throw err;
        }
        console.log(`Connection to ${connection.config.server} established`);
        executeStatement(sqlStatement);
      });
      
      connection.connect();
      
      const executeStatement = (statement) =>  {
        const request = new Request(statement, (err, rowCount) => {
          if (err) {
            throw err;
          }
      
          console.log('DONE!');
          connection.close();
        });
      
        // Emits a 'DoneInProc' event when completed.
        request.on('row', (columns) => {
          columns.forEach((column) => {
            if (column.value === null) {
              console.log('NULL');
            } else {
              console.log(column.value);
            }
          });
        });
      
        request.on('done', (rowCount) => {
          console.log('Done is called!');
        });
      
        request.on('doneInProc', (rowCount, more) => {
          console.log(rowCount + ' rows returned');
        });
      
        // In SQL Server 2000 you may need: connection.execSqlBatch(request);
        connection.execSql(request);
      }
}
