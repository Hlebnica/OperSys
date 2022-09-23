# Написать программу, реализующую модель "поставщик-потребитель" с буфером длины 10.
# Участвующие в модели процессы реализовать в виде нитей.
# Предусмотреть независимое управление работой каждой нити:
# запуск, остановку, паузу в работе и изменение скорости работы.
# Для наглядности содержимое буфера должно отображаться в интерфейсе программы.

# Воспользоваться стандартным классом Thread, где реализованы все необходимые методы.


import random
import os
from time import sleep
from threading import Thread
import keyboard

bufer = []
generator_semaphore = 10
consumer_semaphore = 0

consumer_sleep_time = 0.5
generator_sleep_time = 0.5


def speed_up_consumer(*args):
    global generator_sleep_time, consumer_sleep_time
    generator_sleep_time += 0.1
    if generator_sleep_time > 0.5 and consumer_sleep_time > 0.5:
        consumer_sleep_time = 0.5
        generator_sleep_time = 0.5


def speed_up_generator(*args):
    global consumer_sleep_time, generator_sleep_time
    consumer_sleep_time += 0.1
    if generator_sleep_time > 0.5 and consumer_sleep_time > 0.5:
        consumer_sleep_time = 0.5
        generator_sleep_time = 0.5


def write_to_bufer():
    global bufer
    bufer.insert(0, random.randint(0, 10))


def read_from_bufer():
    global bufer
    os.system('clear')
    p = bufer.pop()
    print(f'{bufer}\n{len(bufer)}',
          f'\ngenerator_sleep_time --> {generator_sleep_time}',
          f'\nconsumer_sleep_time --> {consumer_sleep_time}')


def generator():
    global consumer_semaphore, generator_semaphore
    while True:
        if generator_semaphore >= 0:
            write_to_bufer()
            consumer_semaphore += 1
            generator_semaphore -= 1
            sleep(generator_sleep_time)


def consumer():
    global consumer_semaphore, generator_semaphore
    while True:
        if consumer_semaphore > 0:
            read_from_bufer()
            consumer_semaphore -= 1
            generator_semaphore += 1
            sleep(consumer_sleep_time)


if __name__ == "__main__":
    keyboard.on_release_key('1', speed_up_generator)
    keyboard.on_release_key('2', speed_up_consumer)

    generator_thread = Thread(target=generator)
    consumer_thread = Thread(target=consumer)
    generator_thread.start()
    consumer_thread.start()
    generator_thread.join()
    consumer_thread.join()
