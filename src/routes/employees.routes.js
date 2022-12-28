import { Router } from "express";

const router = Router();

router.get("/employees", (req, res) => res.send("get employeese"));
router.post("/employees", (req, res) => res.send("create employeese"));
router.put("/employees", (req, res) => res.send("update employeese"));
router.delete("/employees", (req, res) => res.send("delete employeese"));

export default router;
