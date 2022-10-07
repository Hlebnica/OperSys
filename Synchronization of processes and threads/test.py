# Написать программу, реализующую модель "поставщик-потребитель" с буфером длины 10.
# Участвующие в модели процессы реализовать в виде нитей.
# Предусмотреть независимое управление работой каждой нити:
# запуск, остановку, паузу в работе и изменение скорости работы.
# Для наглядности содержимое буфера должно отображаться в интерфейсе программы.

# Воспользоваться стандартным классом Thread, где реализованы все необходимые методы.


import random
from time import sleep
from threading import Thread
import keyboard

buffer = []
generator_semaphore = 10
consumer_semaphore = 0

generator_sleep_time = 0.5
consumer_sleep_time = 0.5

generator_pause = True
consumer_pause = True


def generator_pause_changer(*args):
    global generator_pause
    if generator_pause:
        generator_pause = False
    if not generator_pause:
        generator_pause = True


def consumer_pause_changer(*args):
    global consumer_pause
    if consumer_pause:
        consumer_pause = False
    if not consumer_pause:
        consumer_pause = True


def speed_up_consumer(*args):
    global generator_sleep_time, consumer_sleep_time
    generator_sleep_time += 0.1


def speed_up_generator(*args):
    global consumer_sleep_time, generator_sleep_time
    consumer_sleep_time += 0.1


def speed_down_consumer(*args):
    global generator_sleep_time, consumer_sleep_time
    generator_sleep_time -= 0.1


def speed_down_generator(*args):
    global consumer_sleep_time, generator_sleep_time
    consumer_sleep_time -= 0.1


def write_to_buffer():
    global buffer
    buffer.insert(0, random.randint(0, 10))


def read_from_buffer():
    global buffer
    buffer.pop()
    print(f'{buffer}\n len of buffer {len(buffer)}',
          f'\ngenerator_sleep_time --> {generator_sleep_time}',
          f'\nconsumer_sleep_time --> {consumer_sleep_time}')


def generator():
    global consumer_semaphore, generator_semaphore
    while generator_pause:
        if generator_semaphore >= 0:
            write_to_buffer()
            consumer_semaphore += 1
            generator_semaphore -= 1
            sleep(generator_sleep_time)


def consumer():
    global consumer_semaphore, generator_semaphore
    while consumer_pause:
        if consumer_semaphore > 0:
            read_from_buffer()
            consumer_semaphore -= 1
            generator_semaphore += 1
            sleep(consumer_sleep_time)


keyboard.on_release_key('1', speed_up_generator)
keyboard.on_release_key('2', speed_up_consumer)
keyboard.on_release_key('3', speed_down_generator)
keyboard.on_release_key('4', speed_down_consumer)
keyboard.on_release_key('5', generator_pause_changer)
keyboard.on_release_key('6', consumer_pause_changer)

generator_thread = Thread(target=generator)
consumer_thread = Thread(target=consumer)
generator_thread.start()
consumer_thread.start()
generator_thread.join()
consumer_thread.join()
