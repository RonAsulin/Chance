SELECT * FROM chance WHERE rid=(SELECT MAX(rid) FROM chance);