import express from "express";

const app = express();

app.get("/employees", (req, res) => res.send("get employeese"));
app.post("/employees", (req, res) => res.send("create employeese"));
app.put("/employees", (req, res) => res.send("update employeese"));
app.delete("/employees", (req, res) => res.send("delete employeese"));

app.listen(3000);
console.log("Listening on port");
