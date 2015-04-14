
Create table worktypes
(
	pworktype INTEGER PRIMARY KEY,
	name TEXT
);

Create table workers
(
	pworker INTEGER PRIMARY KEY,
	name TEXT,
	contacts TEXT
);

Create table customers
(
	pcustomer INTEGER PRIMARY KEY,
	name TEXT,
	contacts TEXT
);

Create table levels
(
	plevel INTEGER PRIMARY KEY,
	pworktype INTEGER,
	name TEXT,
	value INTEGER,
	FOREIGN KEY(pworktype) REFERENCES worktypes(pworktype)
);

Create table orders
(
	porder INTEGER PRIMARY KEY,
	pcustomer INTEGER,
	edate INTEGER,
	bdate INTEGER,
	cdate INTEGER,
	name TEXT,
	object TEXT,
	fmark INTEGER,
	ecost INTEGER,
	fcost INTEGER,
	FOREIGN KEY(pcustomer) REFERENCES customers(pcustomer)
);

Create table points
(
	ppoint INTEGER PRIMARY KEY,
	plevel INTEGER,
	porder INTEGER,
	descript TEXT,
	amount INTEGER,
	ecost INTEGER,
	fcost INTEGER,
	edate INTEGER,
	FOREIGN KEY(porder) REFERENCES orders(porder),
	FOREIGN KEY(plevel) REFERENCES levels(plevel)
);

Create table assignments
(
	passign INTEGER PRIMARY KEY,
	pworker INTEGER,
	ppoint INTEGER,
	amount INTEGER,
	FOREIGN KEY(pworker) REFERENCES workers(pworker),
	FOREIGN KEY(ppoint) REFERENCES points(ppoint)
);

Create table intervals
(
	pinterval INTEGER PRIMARY KEY,
	passign INTEGER,
	edate INTEGER,
	estime INTEGER,
	eetime INTEGER,
	fdate INTEGER,
	fstime INTEGER,
	fetime INTEGER,
	emark INTEGER,
	FOREIGN KEY(passign) REFERENCES assignments(passign)
);

Create table quals
(
	pqual INTEGER PRIMARY KEY,
	pworktype INTEGER,
	name TEXT,
	lvalue INTEGER,
	value INTEGER,
	FOREIGN KEY(pworktype) REFERENCES worktypes(pworktype)
);

Create table specials
(
	pspec INTEGER PRIMARY KEY,
	pworker INTEGER,
	pqual INTEGER,
	FOREIGN KEY(pworker) REFERENCES workers(pworker),
	FOREIGN KEY(pqual) REFERENCES quals(pqual)
);
