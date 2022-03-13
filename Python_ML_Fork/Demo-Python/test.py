from test1 import emailProcess,printMsg

def main():
    emails = ['nhan@gmail.com','youtube@nhan.dev']
    for email in emails:
        username,email_domain = emailProcess(email)
        printMsg(username,email_domain)

if __name__ == "__main__":
    main()