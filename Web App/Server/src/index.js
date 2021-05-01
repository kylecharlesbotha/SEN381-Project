const express = require("express");
const morgan = require("morgan");
const helmet = require("helmet");
require("dotenv").config({ path: __dirname + "/../.env" });
const port = process.env.PORT || 3001;
const con = require("./db/db.js");
const app = express();

app.use(morgan("dev"));
app.use(helmet());
app.use(express.json());

app.get("/", (req, res, next) => {
    try {
      //throw new Error("Error");
      res.json({
        success: "true",
        message: `Welcome to premier service solutions API`,
        data: {},
      });
    } catch (error) {
      next(error);
    }
  });


app.get("/testdb", (req, res, next) => {
  try {
    //throw new Error("Error");
    con("DELETE FROM tblTest WHERE name='Kyle1'");
    res.send("Done");
    next();
  } catch (error) {
    next(error);
  }
});  
  //Error
app.use((error, req, res, next) => {
    if (error.status) {
      res.status(error.status);
    } else {
      res.status(500);
    }
    const stack = process.env.NODE_ENV === "production" ? error.stack : "🌌";
    res.json({
      message: error.message,
      stack,
    });
});
  
app.listen(port, () => {
    console.log(`Listening on http://localhost:${port}`);
});