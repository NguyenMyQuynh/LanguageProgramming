def emailProcess(email):
    #youtube
    email_username = email[0:email.index("@")]
    email_domain = email[email.index("@")+1:]
    #print(f"username is {email_username}")
    return [email_username,email_domain]
def printMsg(email_username, email_domain):
    print(f"Username is {email_username}; Email Domain is {email_domain}")
def main():
    email=input("please :").strip()
    #print(f"Hello{email}")
    email_username, email_domain = emailProcess(email)
    printMsg(email_username, email_domain)
if __name__ == "__main__":
    main()