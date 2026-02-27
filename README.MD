# Asynchronous Programming

This project is a **.NET 9 Web API** running inside Docker, using **Redis** as a supporting service.

The main goal of this project is to demonstrate **asynchronous programming techniques** by making concurrent calls to an external public API (Hacker News). The application retrieves the best stories available on Hacker News and exposes them through a custom API endpoint.

The external service used is the official Hacker News API, and this project focuses on efficiently handling multiple asynchronous requests while maintaining performance and reliability.

The application exposes its HTTP endpoints through Swagger UI and can be executed using Docker Compose.

---

## Project 

This project demonstrates:

- Asynchronous programming in .NET
- Parallel processing of external HTTP requests
- Resilience when consuming external APIs
- Containerized execution using Docker
- Integration with Redis as a supporting service

The system calls the Hacker News public API to retrieve the current best stories and returns a customized response based on the requested number of items.

---

## Prerequisites

Before running the application, make sure you have installed:

- **Docker**
- **Docker Compose**

No additional local setup is required.

---

## How to Run the Application

1. Open a terminal in the **root folder of the project** (where the `docker-compose.yml` file is located).

2. Run the application using:

docker compose up --build