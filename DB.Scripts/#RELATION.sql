alter table [PRODUCT_IMAGE] add CONSTRAINT PRODUCT_IMAGE_F01 FOREIGN KEY ([ProductId]) REFERENCES [PRODUCT](Id)

alter table [ORDER_PRODUCT] add CONSTRAINT ORDER_PRODUCT_F01 FOREIGN KEY ([OrderId]) REFERENCES [ORDER](Id)
alter table [ORDER_PRODUCT] add CONSTRAINT ORDER_PRODUCT_F02 FOREIGN KEY ([ProductId]) REFERENCES [PRODUCT](Id)

