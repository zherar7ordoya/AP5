# ====================================================================
# Author:       Gerardo Tordoya
# Create date:  2023-01-19
# Description:  Gerardo, te sugiero que dividas en tres este proyecto:
#                   1) MVC sin persistencia
#                   2) MVC con persistencia
#                   3) MVC con ORM
# ====================================================================

# FUENTE:
# https://www.giacomodebidda.com/posts/mvc-pattern-in-python-introduction-and-basicmodel/




# model_view_controller.py
import basic_backend
import sqlite_backend
import dataset_backend
import mvc_exceptions as mvc_exc


# /////////////////////////////////////////////////////////////// BUSINESS LOGIC

class ModelBasic(object):

    def __init__(self, application_items):
        self._item_type = 'product'
        self.create_items(application_items)

    @property
    def item_type(self):
        return self._item_type

    @item_type.setter
    def item_type(self, new_item_type):
        self._item_type = new_item_type

    def create_item(self, name, price, quantity):
        basic_backend.create_item(name, price, quantity)

    def create_items(self, items):
        basic_backend.create_items(items)

    def read_item(self, name):
        return basic_backend.read_item(name)

    def read_items(self):
        return basic_backend.read_items()

    def update_item(self, name, price, quantity):
        basic_backend.update_item(name, price, quantity)

    def delete_item(self, name):
        basic_backend.delete_item(name)




# /////////////////////////////////////////////////////////// PRESENTATION LAYER

# There is no logic in the View class, and all of its methods are normal
# functions (see the @staticmethod decorator). Also, there is no mention of the
# other two components of the MVC pattern. This means that if you want to design
# a fancy UI for your application, you just have to replace the View class.

class View(object):

    @staticmethod
    def show_bullet_point_list(item_type, items):
        print('--- {} LIST ---'.format(item_type.upper()))
        for item in items:
            print('* {}'.format(item))

    @staticmethod
    def show_number_point_list(item_type, items):
        print('--- {} LIST ---'.format(item_type.upper()))
        for i, item in enumerate(items):
            print('{}. {}'.format(i+1, item))

    @staticmethod
    def show_item(item_type, item, item_info):
        print('///////////////////////////////////////////////////////////////')
        print('Good news, we have some {}!'.format(item.upper()))
        print('{} INFO: {}'.format(item_type.upper(), item_info))
        print('///////////////////////////////////////////////////////////////')

    @staticmethod
    def display_missing_item_error(item, err):
        print('**************************************************************')
        print('We are sorry, we have no {}!'.format(item.upper()))
        print('{}'.format(err.args[0]))
        print('**************************************************************')

    @staticmethod
    def display_item_already_stored_error(item, item_type, err):
        print('**************************************************************')
        print('Hey! We already have {} in our {} list!'
              .format(item.upper(), item_type))
        print('{}'.format(err.args[0]))
        print('**************************************************************')

    @staticmethod
    def display_item_not_yet_stored_error(item, item_type, err):
        print('**************************************************************')
        print('We don\'t have any {} in our {} list. Please insert it first!'
              .format(item.upper(), item_type))
        print('{}'.format(err.args[0]))
        print('**************************************************************')

    @staticmethod
    def display_item_stored(item, item_type):
        print('++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++')
        print('Hooray! We have just added some {} to our {} list!'
              .format(item.upper(), item_type))
        print('++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++')

    @staticmethod
    def display_change_item_type(older, newer):
        print('---   ---   ---   ---   ---   ---   ---   ---   ---   ---   --')
        print('Change item type from "{}" to "{}"'.format(older, newer))
        print('---   ---   ---   ---   ---   ---   ---   ---   ---   ---   --')

    @staticmethod
    def display_item_updated(item, o_price, o_quantity, n_price, n_quantity):
        print('---   ---   ---   ---   ---   ---   ---   ---   ---   ---   --')
        print('Change {} price: {} --> {}'
              .format(item, o_price, n_price))
        print('Change {} quantity: {} --> {}'
              .format(item, o_quantity, n_quantity))
        print('---   ---   ---   ---   ---   ---   ---   ---   ---   ---   --')

    @staticmethod
    def display_item_deletion(name):
        print('--------------------------------------------------------------')
        print('We have just removed {} from our list'.format(name))
        print('--------------------------------------------------------------')






# /////////////////////////////////////////////////////////////////// CONTROLLER

# As you can see, when you instantiate a Controller you have to specify a Model
# and a View. However, this is just «composition», so whenever you want to use a
# different Model, and/or a different View, you just have to plug them in when
# you instantiate the Controller. The Controller accepts user’s inputs and
# «delegates» data representation to the View and data handling to the Model.


# Why do Python classes inherit object?
# Because Python 2.x is a mess. In Python 3.x, all classes inherit object by
# default, so you don’t have to specify it.
# ---
# Is there any reason for a class declaration to inherit from object?
# In Python 3, apart from compatibility between Python 2 and 3, no reason.
# In Python 2, many reasons.

class Controller(object):

    def __init__(self, model, view):
        self.model = model
        self.view = view

    def show_items(self, bullet_points=False):
        items = self.model.read_items()
        item_type = self.model.item_type
        if bullet_points:
            self.view.show_bullet_point_list(item_type, items)
        else:
            self.view.show_number_point_list(item_type, items)

    def show_item(self, item_name):
        try:
            item = self.model.read_item(item_name)
            item_type = self.model.item_type
            self.view.show_item(item_type, item_name, item)
        except mvc_exc.ItemNotStored as e:
            self.view.display_missing_item_error(item_name, e)

    def insert_item(self, name, price, quantity):
        assert price > 0, 'price must be greater than 0'
        assert quantity >= 0, 'quantity must be greater than or equal to 0'
        item_type = self.model.item_type
        try:
            self.model.create_item(name, price, quantity)
            self.view.display_item_stored(name, item_type)
        except mvc_exc.ItemAlreadyStored as e:
            self.view.display_item_already_stored_error(name, item_type, e)

    def update_item(self, name, price, quantity):
        assert price > 0, 'price must be greater than 0'
        assert quantity >= 0, 'quantity must be greater than or equal to 0'
        item_type = self.model.item_type

        try:
            older = self.model.read_item(name)
            self.model.update_item(name, price, quantity)
            self.view.display_item_updated(
                name, older['price'], older['quantity'], price, quantity)
        except mvc_exc.ItemNotStored as e:
            self.view.display_item_not_yet_stored_error(name, item_type, e)
            # If the item is not yet stored, and we have performed an update, we
            # have two options:
            #       1. Do nothing or...
            #       2. Call insert_item to add it.
            # self.insert_item(name, price, quantity)

    def update_item_type(self, new_item_type):
        old_item_type = self.model.item_type
        self.model.item_type = new_item_type
        self.view.display_change_item_type(old_item_type, new_item_type)

    def delete_item(self, name):
        item_type = self.model.item_type
        try:
            self.model.delete_item(name)
            self.view.display_item_deletion(name)
        except mvc_exc.ItemNotStored as e:
            self.view.display_item_not_yet_stored_error(name, item_type, e)






class ModelSQLite(object):

    def __init__(self, application_items):
        self._item_type = 'product'
        self._connection = sqlite_backend.connect_to_db(sqlite_backend.DB_name)
        sqlite_backend.create_table(self.connection, self._item_type)
        self.create_items(application_items)

    @property
    def connection(self):
        return self._connection

    @property
    def item_type(self):
        return self._item_type

    @item_type.setter
    def item_type(self, new_item_type):
        self._item_type = new_item_type

    def create_item(self, name, price, quantity):
        sqlite_backend.insert_one(
            self.connection, name, price, quantity, table_name=self.item_type)

    def create_items(self, items):
        sqlite_backend.insert_many(
            self.connection, items, table_name=self.item_type)

    def read_item(self, name):
        return sqlite_backend.select_one(
            self.connection, name, table_name=self.item_type)

    def read_items(self):
        return sqlite_backend.select_all(
            self.connection, table_name=self.item_type)

    def update_item(self, name, price, quantity):
        sqlite_backend.update_one(
            self.connection, name, price, quantity, table_name=self.item_type)

    def delete_item(self, name):
        sqlite_backend.delete_one(
            self.connection, name, table_name=self.item_type)





class ModelDataset(object):

    def __init__(self, application_items):
        self._item_type = 'product'
        self._connection = dataset_backend.connect_to_db(
            dataset_backend.DB_name, db_engine='sqlite')
        dataset_backend.create_table(self.connection, self._item_type)
        self.create_items(application_items)

    @property
    def item_type(self):
        return self._item_type

    @item_type.setter
    def item_type(self, new_item_type):
        self._item_type = new_item_type

    @property
    def connection(self):
        return self._connection

    def create_item(self, name, price, quantity):
        dataset_backend.insert_one(
            self.connection, name, price, quantity, table_name=self.item_type)

    def create_items(self, items):
        dataset_backend.insert_many(
            self.connection, items, table_name=self.item_type)

    def read_item(self, name):
        return dataset_backend.select_one(
            self.connection, name, table_name=self.item_type)

    def read_items(self):
        return dataset_backend.select_all(
            self.connection, table_name=self.item_type)

    def update_item(self, name, price, quantity):
        dataset_backend.update_one(
            self.connection, name, price, quantity, table_name=self.item_type)

    def delete_item(self, name):
        dataset_backend.delete_one(
            self.connection, name, table_name=self.item_type)










# Test.-------------------------------------------------------------------------

# def main():
#     my_items = [
#         {'name': 'bread', 'price': 0.5, 'quantity': 20},
#         {'name': 'milk', 'price': 1.0, 'quantity': 10},
#         {'name': 'wine', 'price': 10.0, 'quantity': 5},
#     ]
#
#     c = Controller(ModelBasic(my_items), View())
#
#     # Show all items as number point list.
#     c.show_items()
#
#     # Show all items as bullet point list.
#     c.show_items(bullet_points=True)
#
#     # Show a single item when does not exist.
#     c.show_item('chocolate')
#
#     # Show a single item when exists.
#     c.show_item('bread')
#
#     # Insert a repeated item.
#     c.insert_item('bread', price=1.0, quantity=5)
#
#     # Insert a new item.
#     c.insert_item('chocolate', price=2.0, quantity=10)
#
#     # Check that the item has been inserted.
#     c.show_item('chocolate')
#
#     # Update an unexisting item.
#     c.update_item('ice cream', price=3.5, quantity=20)
#
#     # Update an existing item.
#     c.update_item('milk', price=1.2, quantity=20)
#
#     # Delete an unexisting item.
#     c.delete_item('fish')
#
#     # Delete an existing item.
#     c.delete_item('bread')






if __name__ == '__main__':
    # main()

    # my_items = [
    #     {'name': 'bread', 'price': 0.5, 'quantity': 20},
    #     {'name': 'milk', 'price': 1.0, 'quantity': 10},
    #     {'name': 'wine', 'price': 10.0, 'quantity': 5},
    # ]
    #
    # c = Controller(ModelSQLite(my_items), View())
    # c.show_items()
    # c.show_items(bullet_points=True)
    # c.show_item('chocolate')
    # c.show_item('bread')
    #
    # c.insert_item('bread', price=1.0, quantity=5)
    # c.insert_item('chocolate', price=2.0, quantity=10)
    # c.show_item('chocolate')
    #
    # c.update_item('milk', price=1.2, quantity=20)
    # c.update_item('ice cream', price=3.5, quantity=20)
    #
    # c.delete_item('fish')
    # c.delete_item('bread')
    #
    # c.show_items()
    #
    # # we close the current sqlite database connection explicitly
    # if type(c.model) is ModelSQLite:
    #     sqlite_backend.disconnect_from_db(
    #         sqlite_backend.DB_name, c.model.connection)
    #     # the sqlite backend understands that it needs to open a new connection
    #     c.show_items()

    my_items = [
        {'name': 'bread', 'price': 0.5, 'quantity': 20},
        {'name': 'milk', 'price': 1.0, 'quantity': 10},
        {'name': 'wine', 'price': 10.0, 'quantity': 5},
    ]

    c = Controller(ModelDataset(my_items), View())

    c.show_items()
    c.show_items(bullet_points=True)
    c.show_item('chocolate')
    c.show_item('bread')

    c.insert_item('bread', price=1.0, quantity=5)
    c.insert_item('chocolate', price=2.0, quantity=10)
    c.show_item('chocolate')

    c.update_item('milk', price=1.2, quantity=20)
    c.update_item('ice cream', price=3.5, quantity=20)

    c.delete_item('fish')
    c.delete_item('bread')

    c.show_items()
