
-- Setup Situation 
CREATE TABLE ShoeItem (
    s_name    text,          	-- primary key
    s_standard_price   integer, -- standard price
    s_discount   real       	-- discount   
);
-- 11 count 
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
INSERT INTO ShoeItem VALUES ('T10',100, 10);
-- 1 count 
INSERT INTO ShoeItem VALUES ('T20',200, 20);
-- 2 count 
INSERT INTO ShoeItem VALUES ('T30',300, 30);
INSERT INTO ShoeItem VALUES ('T30',300, 30);
-- 5 count  
INSERT INTO ShoeItem VALUES ('T30',300, 30);
INSERT INTO ShoeItem VALUES ('T30',300, 30);
INSERT INTO ShoeItem VALUES ('T30',300, 30);
INSERT INTO ShoeItem VALUES ('T30',300, 30);
INSERT INTO ShoeItem VALUES ('T30',300, 30);

-- Function with TotalTax
CREATE FUNCTION ShoeMessage(s_name text) RETURNS text AS $$
DECLARE message text;
DECLARE count_shoe int;
BEGIN
      SELECT COUNT(*) INTO count_shoe
	FROM ShoeItem
	WHERE ShoeItem.s_name = ShoeMessage.s_name;

    CASE 
	WHEN count_shoe = 0 THEN
		message:= 'Sorry! We are out of stock.';
	WHEN count_shoe = 1 THEN
		message:= 'Hurry! We have the last piece remaining.';
	WHEN count_shoe BETWEEN 2 and 9 THEN
		message:= 'Lucky! We have have last few remaining.';
	ELSE 
		message:= 'No Rush! We have plenty available.';
	END CASE;
    RETURN message;
END;
$$ LANGUAGE plpgsql;

-- Select Data - count 11
SELECT * 
FROM ShoeItem, ShoeMessage('T10');
-- Select Data - count 1
SELECT * 
FROM ShoeItem, ShoeMessage('T20');
-- Select Data - count 2
SELECT * 
FROM ShoeItem, ShoeMessage('T30');
-- Select Data - count 5
SELECT * 
FROM ShoeItem, ShoeMessage('T40');

-- Clean up
DROP TABLE ShoeItem;
DROP FUNCTION ShoeMessage(text);
