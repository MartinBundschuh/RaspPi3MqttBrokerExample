# RaspPi3MqttBrokerExample

Raspberry Pi 3 Project using the MQTT protocoll.

This Project shows how to host an MQTT broker from RaspberryPi 3. The goal ist to controll Pi from Windows phone.
There are three different projects.

- RaspPi3.MqttBrokerHost
Here it is shown, how to host a local MQTT broker on an Raspberry Pi with Windows IoT Core. The broker is running on a background task. The project takes use of the GnatMQ Framework.

- RaspPi3.MqttBrokerHostVisual
In addition to the first project, you can see the broker hosting status. It's possbile to stop and rerun the broker. The project is written as an Universal Windows App. The Okra Framework is used to handle the MVVM pattern.

- RaspPi3.MqttBrokerPiConsumer
This project shows how to connect to an MQTT broker from an Raspberry Pi. Used Frameworks are the Okra Framework to hande MVVM pattern in the Universal Windows app. M2Mqtt provides the connection Framework to CloudMQTT broker where I use the free hosting service. To store data locally I use the SQLite.Net Framework.
I wrote a similar class to the DbContext, since EF is not usable in ARM runtime. Because of this i have kind of an simple and own EF. 
To send and receive messages via the broker I use Json serialization.
To be able to extend the poject easily for further classes, I wrote custom Attributes to extend functionallity almost only with DataAnnotations. Ther has only to be added an ObservableCollection to te SQLiteHandler.
There is also an visualization. You can disconnect and connect, change Broker or Port information and have a littel overview of the latest received and sent messages.

For first setup you need to add your WiFi an Broker User/Password Compinations. Also you neet to select an approprative MQTT Broker. Then run the setup method once. You can find the loc within the Task List.

Comming soon:
- Connect to WiFi network
- Calling Azure WebServices
- Store Messages in Azure
