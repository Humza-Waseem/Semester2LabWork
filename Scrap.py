import requests
from bs4 import BeautifulSoup

url = 'https://www.pakwheels.com/used-cars/automatic/57336'

response = requests.get(url)

if response.status_code == 200:
    soup = BeautifulSoup(response.content, 'html.parser') 


    car_names = soup.find_all(class_='car-name ad-detail-path',)

    if car_names:

        for car_name in car_names:

            print(car_name.text)
            # title = car_name.find_previous('title')
            # print(title)

    else:
        print("No car names found with the specified class.")
else:
    print(f"Error: Unable to retrieve content. Status code: {response.status_code}")

