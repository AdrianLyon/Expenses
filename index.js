import express from "express";
import { pool } from "./db.js";

const app = express();

app.get("/ping", async (req, res) => {
  const [result] = await pool.query('SELECT "PING" AS result');
  res.json(result[0]);
});

app.get("/employees", (req, res) => res.send("get employeese"));
app.post("/employees", (req, res) => res.send("create employeese"));
app.put("/employees", (req, res) => res.send("update employeese"));
app.delete("/employees", (req, res) => res.send("delete employeese"));

app.listen(3000);
console.log("Listening on port");
