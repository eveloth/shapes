-- SETUP

CREATE TABLE IF NOT EXISTS products (
  id INT IDENTITY (1, 1) PRIMARY KEY,
  name NVARCHAR(512) NOT NULL,
  caterory_id INT,
  CONSTRAINT fk_category FOREIGN KEY (category_id)
  REFERENCES categories(id)
);

CREATE TABLE IF NOT EXISTS categories (
  id INT IDENTITY (1, 1) PRIMARY KEY,
  name NVARCHAR(512) NOT NULL,
);

-- QUERY

SELECT p.name, c.name FROM products p LEFT JOIN categories c ON p.caterory_id = c.id;
