"""
  @title        CAJERO BANCARIO
  @description  Ejercicio del banco con POO
  @author       Gerardo Tordoya
  @date         2022-09-26
"""

# ─── UNICODE BLOCKS -----------------------------------------------------------
#          Box Drawing      => www.compart.com/en/unicode/block/U+2500         #
#          Block Elements   => www.compart.com/en/unicode/block/U+2580         #
#          Geometric Shapes => www.compart.com/en/unicode/block/U+25A0         #

from datetime import datetime
from os.path import exists
import json
import math
import os
import random
import sys

# ─── CONSTANTS ────────────────────────────────────────────────────────────────

FILE_PATH = "data.json"

# ─── DATABASE ─────────────────────────────────────────────────────────────────

def get_data():
    """ Reads the bank information from the data file. """

    # assume none existent file as empty file
    if not exists(FILE_PATH):
        return {}
    archivo = open(FILE_PATH, encoding="utf-8")
    data = archivo.read()
    # convert string json to python object
    return json.loads(data)


def set_data(data):
    """  Writes the bank information into the data file """
    with open(FILE_PATH, "w", encoding="utf-8") as archivo:
        json_data = json.dumps(data)
        archivo.write(json_data)

def get_users_as_list():
    """
    This functions loads the user data and converts it
    from a dictionary to a list and then appends the
    account_number as a key from outside into the the
    data object.
    """
    result = []
    users = get_data()
    for user_account_number in users:
        user_data = users[user_account_number]
        user_data["account_number"] = user_account_number
        result.append(user_data)
    results_as_ll = list_to_linked_list(result)
    return results_as_ll


# ─── LINKED LIST ──────────────────────────────────────────────────────────────

class LinkedList:
    """ A linkedlist node """

    def __init__(self, _value, _next):
        """ Creates the node with a value and reference to the next object (node) """

        self.value = _value
        self.next = _next


    def index(self, index):
        """ Similar to A[i], this works as A.index(i) """

        if index == 0:
            return self.value
        if self.next is None:
            return None
        return self.next.index(index - 1)


    def set_index(self, index, value):
        """ Similar to A[i] = value, this is A.set_index(i, value) """

        if index == 0:
            self.value = value
        else:
            self.next.set_index(index - 1, value)


    def size(self):
        """ Similar to len(A), this is A.size() """

        if self.next is None:
            return 1
        return 1 + self.next.size()


    def append(self, nodo):
        """ Appends a new node to the end of nodes """

        if self.next is None:
            self.next = LinkedList(nodo, None)
        else:
            self.next.append(nodo)


def list_to_linked_list(arr):
    """ Converts a Python List to a LinkedList """
    nodo = None
    for i in range(len(arr) - 1, -1, -1):
        node = LinkedList(arr[i], nodo)
        nodo = node
    return nodo


# ─── HEAP SORT ────────────────────────────────────────────────────────────────

def heap_sort(input_list, field):
    """
    A custom implementation of the heap sort function that
    also gets a field and then assumes the input_list contains
    data objects. So it sorts based on a common key on all those
    functions. This makes possible to sort users based on different
    aspects, like based on full name or phone number
    """
    range_start = int((input_list.size()-2)/2)
    for start in range(range_start, -1, -1):
        sift_down(input_list, field, start, input_list.size()-1)

    range_start = int(input_list.size()-1)
    for end_index in range(range_start, 0, -1):
        swap(input_list, end_index, 0)
        sift_down(input_list, field, 0, end_index - 1)
    return input_list


def swap(input_list, elemento_a, elemento_b):
    """ Swaps two elements of a list with the python shorthand """

    a_value = input_list.index(elemento_a)
    b_value = input_list.index(elemento_b)
    input_list.set_index(elemento_a, b_value)
    input_list.set_index(elemento_b, a_value)


def sift_down(input_list, field, start_index, end_index):
    """
    The "Sift Down" function of the heap sort algorithm,
    customized to also include object fields.
    """
    root_index = start_index
    while True:
        child = root_index * 2 + 1
        if child > end_index:
            break
        if (child + 1 <= end_index and
        input_list.index(child)[field] < input_list.index(child + 1)[field]):
            child += 1
        if input_list.index(root_index)[field] < input_list.index(child)[field]:
            swap(input_list, child, root_index)
            root_index = child
        else:
            break


# ─── BINARY SEARCH ──────────────────────────────────────────────────────────────

def text_binary_search(input_list, field, query):
    """
    A custom binary search implementation that:
    (1) Assumes the input_list to have elements of type object
        and then sorts by a common key in all those objects name
        "field"
    (2) Make the text lowercase and trims the text in the fields
        so for example "foo bar" can match "FooBar"
    """
    low = 0
    high = input_list.size() - 1
    query = make_text_searchable(query)
    while low <= high:
        mid = math.floor((low + high) / 2)
        if make_text_searchable(input_list.index(mid)[field]) > query:
            high = mid - 1
        elif make_text_searchable(input_list.index(mid)[field]) < query:
            low = mid + 1
        else:
            return mid
    return -1


def make_text_searchable(text):
    """ Make the text lowercase the text and removes spaces """

    return text.lower().replace(" ", "")


# ─── ACCOUNT NUMBER ───────────────────────────────────────────────────────────


def generate_account_number():
    """
    Generates a new unique account number. The bank
    prefix number is 1717 2424, the 8 other digits are
    then generated randomly
    """
    prefix = "17172424"
    result = ""
    for _ in range(0, 8):
        random_number = random.randint(1, 9)
        result += str(random_number)

    return prefix + result


# ─── TRANSACTION ──────────────────────────────────────────────────────────────

def perform_transaction(sender_number, receiver_number, amount):
    """
    Given two account numbers and a transaction amount, this will move
    the money from the sender account to the recipient account.
    """
    users = get_data()

    if sender_number not in users:
        print("Did not found the account with number: " + sender_number)
        return

    if receiver_number not in users:
        print("Did not found the account with number: " + receiver_number)
        return

    if users[sender_number]["balance"] < amount:
        print("your account balance is not enough")
        return

    users[sender_number]["balance"] -= amount
    users[receiver_number]["balance"] += amount

    set_data(users)

    print("Transferred ", amount, "$ from account",
          users[sender_number]["full_name"], "to", users[receiver_number]["full_name"])


# ─── UPDATE INFORMATION ───────────────────────────────────────────────────────


def update_information(account_number):
    """
    Given an account number, this asks the user what to change and then
    changes the properties of that.
    """
    users = get_data()
    print_horizontal_line()
    print("► 1 ∙ Full Name ")
    print_horizontal_line()
    print("► 2 ∙ Gender ")
    print_horizontal_line()
    print("► 3 ∙ City ")
    print_horizontal_line()
    print("► 4 ∙ Phone Number ")
    print_horizontal_line()
    command = int(input("What to change? "))
    print_horizontal_line()
    if command == 1:
        new_name = input("New Full Name: ")
        users[account_number]["full_name"] = new_name
    if command == 2:
        new_gender = input("New Gender: ")
        users[account_number]["gender"] = new_gender
    if command == 3:
        new_city = input("New City: ")
        users[account_number]["city"] = new_city
    if command == 4:
        new_phone_number = input("New Phone Number: ")
        users[account_number]["phone_number"] = new_phone_number

    set_data(users)
    clean_terminal_screen()
    display_account_information_by_given_account_number(account_number)


# ─── CREATE A NEW USER ────────────────────────────────────────────────────────

def create_new_user(full_name, balance, gender, city, phone_number):
    """ Creates a new user with the given information """

    users = get_data()
    date = datetime.today().strftime('%Y-%m-%d')
    account_number = generate_account_number()
    users[account_number] = {
        "full_name": full_name,
        "gender": gender,
        "balance": balance,
        "account_creation_date": date,
        "city": city,
        "phone_number": phone_number
    }
    set_data(users)
    display_account_information_by_given_account_number(account_number)


# ─── SEARCH ACCOUNT ───────────────────────────────────────────────────────────


def search_account(field, query):
    """
    Searches the "query" from the user data in the "field" fields
    """
    users = get_users_as_list()
    users = heap_sort(users, field)
    index = text_binary_search(users, field, query)
    if index == -1:
        print("──── Error ──────────────────────────────────")
        print("Found no one as", query)
    else:
        # Se agregan los IF para que pylint no objete debido a None.
        if users is not None:
            user = users.index(index)
            if user is not None:
                display_user_object(user, user["account_number"])


# ─── DELETE AN ACCOUNT ────────────────────────────────────────────────────────

def delete_account(account_number):
    """ Deletes an account if exists, otherwise displays an error. """
    users = get_data()
    if account_number not in users:
        print("Did not found the account with number: " + account_number)
        return
    del users[account_number]
    set_data(users)
    print("Account number", account_number, "removed.")


# ─── INTERFACE TOOLS ──────────────────────────────────────────────────────────

def clean_terminal_screen():
    """
    Cleans the terminal screen by performing a system
    clear command. Cls on windows and Clear on UNIX ones.
    """
    os.system('cls' if os.name == 'nt' else 'clear')


def print_horizontal_line():
    """
    A pretty decorative horizontal line.
    """
    print("─────────────────────────────────────────────")


# ─── DISPLAY USER OBJECT ──────────────────────────────────────────────────────


def display_account_information_by_given_account_number(account_number):
    """
    Displays the information about a given account number
    """
    users = get_data()
    user = users[account_number]
    display_user_object(user, account_number)


def display_user_object(user_object, account_number):
    """
    Displays a single user object. The account_number is taken
    separately since there can be either a list input or a dictionary
    input. In a list input the account_number is within the user object
    and in the dictionary form the account_number is the key mapped
    to the dictionary
    """
    print_horizontal_line()
    print("Full name:      ", user_object["full_name"])
    print("Account number: ", account_number)
    print("Created at:     ", user_object["account_creation_date"])
    print("Balance:        ", user_object["balance"])
    print("Gender:         ", user_object["gender"])
    print("City:           ", user_object["city"])
    print("Phone:          ", user_object["phone_number"])


def display_all_accounts_sorted_by(field):
    """ Displays all the users one after the other, sorted by a given field """

    users = get_users_as_list()
    users = heap_sort(users, field)
    clean_terminal_screen()

    # Los IF se pusieron para que no se rompa el programa si se ingresa un campo
    # que no existe (None).
    if users is not None:
        for i in range(0, users.size()):
            user = users.index(i)
            if user is not None:
                display_user_object(user, user["account_number"])

def beatify_field_name(field):
    """ builds a pretty field name """

    if field == "full_name":
        return "Full Name"
    if field == "account_creation_date":
        return "Account Creation Data"
    if field == "city":
        return "City"
    if field == "gender":
        return "Gender"
    if field == "phone_number":
        return "Phone Number"
    return "Unknown"


def ask_user_what_field_to_sort_the_display_by():
    """ Shows a menu so that the user cas pick a field to sort the data by. """

    print("Sorting by:")
    print_horizontal_line()
    print("► 1 ∙ Full Name ")
    print_horizontal_line()
    print("► 2 ∙ Gender ")
    print_horizontal_line()
    print("► 3 ∙ City ")
    print_horizontal_line()
    print("► 4 ∙ Phone Number ")
    print_horizontal_line()
    print("► 5 ∙ Account Creating Date ")
    print_horizontal_line()
    print("► 6 ∙ Account Number ")
    print()
    command = input("Your option: ")
    if command == "1":
        return "full_name"
    if command == "2":
        return "gender"
    if command == "3":
        return "city"
    if command == "4":
        return "phone_number"
    if command == "5":
        return "account_creation_date"
    if command == "6":
        return "account_number"
    return "full_name"


# ─── DISPLAY MENU ─────────────────────────────────────────────────────────────

def display_menu():
    """
    Displays the welcome menu and asks the user for a
    command to perform (which then performs).

    This also acts as the UI and receives the information
    regarding of the respective functions.
    """
    clean_terminal_screen()

    print()

    print("""
        ┌────────────┐  ╭───────────────────────────╮
        │            │  │ ▶ 1 Create Account        │
        │            │  ├───────────────────────────┤
        │            │  │ ▶ 2 Perform Transaction   │
        │    ╭┼┼╮    │  ├───────────────────────────┤
        │    ╰┼┼╮    │  │ ▶ 3 Update Account Info   │
        │    ╰┼┼╯    │  ├───────────────────────────┤
        │            │  │ ▶ 4 Delete Account        │
        │            │  ├───────────────────────────┤
        │   CAJERO   │  │ ▶ 5 Search Account Info   │
        │  BANCARIO  │  ├───────────────────────────┤
        │            │  │ ▶ 6 View Customer's List  │
        │            │  ├───────────────────────────┤
        │            │  │ ▶ 7 Exit System           │
        └────────────┘  ╰───────────────────────────╯
    """)
    user_choice = int(input("         ▷ Enter your command: "))

    clean_terminal_screen()

    if user_choice == 1:
        print("── Creating a new user ──────────────────────")
        user_name = input("Full Name: ")
        balance = float(input("Balance: "))
        gender = input("Gender: ")
        city = input("City of Residence: ")
        phone_number = input("Phone Number: ")
        create_new_user(user_name, balance, gender, city, phone_number)

    if user_choice == 2:
        print("── Requesting Transaction ───────────────────")
        sender = input("Sender's Account Number:    ")
        receiver = input("Recipient's Account Number: ")
        amount = float(input("Transaction Amount: "))
        perform_transaction(sender, receiver, amount)

    if user_choice == 3:
        print("── Changing Account Information ─────────────")
        account_number = input("Account Number To Change: ")
        update_information(account_number)

    if user_choice == 4:
        print("── Deleting an Account ──────────────────────")
        account_number = input("Account number to delete: ")
        delete_account(account_number)

    if user_choice == 5:
        print("── Search Account ───────────────────────────")
        query = input("Searching for: ")
        clean_terminal_screen()
        search_account("full_name", query)

    if user_choice == 6:
        print("── Displaying all Accounts ──────────────────")
        field = ask_user_what_field_to_sort_the_display_by()
        display_all_accounts_sorted_by(field)

        print("\n\nSorted by user", beatify_field_name(field))

    if user_choice == 7:
        sys.exit()

    print()
    print_horizontal_line()
    input("PRESS ENTER TO CONTINUE ")
    print()


# ─── MAIN ─────────────────────────────────────────────────────────────────────
while True:
    display_menu()
