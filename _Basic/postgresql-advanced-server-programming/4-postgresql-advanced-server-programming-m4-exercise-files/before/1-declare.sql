
-- Setup Situation 
CREATE TABLE ShoeItem (
    s_name    text,          	-- primary key
    s_standard_price   integer, -- standard price
    s_discount   real       	-- discount   
);

INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T20',200, 20);
INSERT INTO ShoeItem VALUES ('T30',300, 30);

-- ------------------------------------
-- Identify total tax on standard price
-- ------------------------------------

-- Function with TotalTax
CREATE FUNCTION SalesTax(tax real) RETURNS real AS $$
BEGIN
    RETURN tax * 0.08;
END;
$$ LANGUAGE plpgsql;

-- Select Data
SELECT * 
FROM SalesTax(2);
SELECT * 
FROM SalesTax(5);

-- Select on Table
SELECT *
FROM ShoeItem, SalesTax (s_standard_price);

-- ------------------------------------
-- Calculate final price after discount with applicable tax
-- ------------------------------------

-- Function with Total Price
CREATE FUNCTION FinalPrice(s_standard_price real, s_discount real, OUT FinalPrice real) AS $$
DECLARE DiscountedPrice real;
DECLARE Tax real;
BEGIN
    DiscountedPrice := s_standard_price - s_discount;
    Tax:= DiscountedPrice * 0.08;
    FinalPrice = DiscountedPrice + Tax;
END;
$$ LANGUAGE plpgsql;

-- Select on Table
SELECT *
FROM ShoeItem, 
SalesTax (s_standard_price),
FinalPrice(s_standard_price,s_discount);

-- ------------------------------------
-- Display final price along with tax applied
-- ------------------------------------

-- Function with Total Price and Tax
CREATE FUNCTION FinalPriceNTax(s_standard_price real, s_discount real, OUT FinalPrice real, OUT Tax real) AS $$
DECLARE DiscountedPrice real;
BEGIN
    DiscountedPrice := s_standard_price - s_discount;
    Tax:= DiscountedPrice * 0.08;
    FinalPrice = DiscountedPrice + Tax;
END;
$$ LANGUAGE plpgsql;

-- Select on Table
SELECT *
FROM ShoeItem, 
SalesTax (s_standard_price),
FinalPriceNTax(s_standard_price,s_discount);


-- Clean up
DROP TABLE ShoeItem;
DROP FUNCTION SalesTax(real);
DROP FUNCTION FinalPrice(real,real);
DROP FUNCTION FinalPriceNTax(real,real);
