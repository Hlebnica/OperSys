import threading
import time
import random
import keyboard

buffer_size = 10
buffer = []
producer_stop = True
consumer_stop = True

producer_sleep_time = 1
consumer_sleep_time = 2.5

# Объявление семафора
mutex = threading.Semaphore()
empty = threading.Semaphore(buffer_size)
full = threading.Semaphore(0)


class Producer(threading.Thread):
    def run(self):
        global buffer_size, buffer, mutex, empty, full, producer_sleep_time, producer_stop

        while producer_stop:
            number = random.randint(1, 90)
            empty.acquire()
            mutex.acquire()

            if len(buffer) <= 10:
                buffer.insert(0, number)
                print("\nProducer produced : ", number)
                print("Buffer len: ", len(buffer))
                print("Items in buffer: ", buffer, "\n")

            mutex.release()
            full.release()

            time.sleep(producer_sleep_time)


class Consumer(threading.Thread):
    def run(self):
        global buffer_size, buffer, mutex, empty, full, consumer_sleep_time, consumer_stop

        while consumer_stop:
            full.acquire()
            mutex.acquire()

            if len(buffer) > 0:
                item = buffer[-1]
                buffer.pop()
                print("Consumer consumed item : ", item)

            mutex.release()
            empty.release()

            time.sleep(consumer_sleep_time)


def sleep_up_producer(*args):
    global producer_sleep_time, consumer_sleep_time
    producer_sleep_time += 0.5
    print("Producer sleep time: ", producer_sleep_time, "\nConsumer sleep time: ", consumer_sleep_time, "\n")


def sleep_down_producer(*args):
    global producer_sleep_time, consumer_sleep_time
    producer_sleep_time -= 0.5
    print("Producer sleep time: ", producer_sleep_time, "\nConsumer sleep time: ", consumer_sleep_time, "\n")


def sleep_up_consumer(*args):
    global producer_sleep_time, consumer_sleep_time
    consumer_sleep_time += 0.5
    print("Producer sleep time: ", producer_sleep_time, "\nConsumer sleep time: ", consumer_sleep_time, "\n")


def sleep_down_consumer(*args):
    global producer_sleep_time, consumer_sleep_time
    consumer_sleep_time -= 0.5
    print("Producer sleep time: ", producer_sleep_time, "\nConsumer sleep time: ", consumer_sleep_time, "\n")


def consumer_stop_changer(*args):
    global consumer_stop
    if consumer_stop:
        consumer_stop = False


def producer_stop_changer(*args):
    global producer_stop
    if producer_stop:
        producer_stop = False


keyboard.on_release_key('1', sleep_up_producer)
keyboard.on_release_key('2', sleep_up_consumer)
keyboard.on_release_key('3', sleep_down_producer)
keyboard.on_release_key('4', sleep_down_consumer)
keyboard.on_release_key('5', sleep_down_consumer)
keyboard.on_release_key('6', consumer_stop, producer_stop)

producer = Producer()
consumer = Consumer()

consumer.start()
producer.start()

producer.join()
consumer.join()
