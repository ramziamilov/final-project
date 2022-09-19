Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Решение задачи:

Пользователь вводит количество элементов массива и далее поочередно вводит каждый его элемент. Для пользователя выводится два массива: заданный пользователем и с элементами, длина которых меньше либо равна 3.
Код изначально считает количестов элементов с длиной <= 3, для задания размерности нового массива и исключения вывода пустых элементов. 

![блок схема](https://viewer.diagrams.net/index.html?tags=%7B%7D&highlight=0000ff&edit=_blank&layers=1&nav=1#R7VpNb%2BIwEP01HLeKnS96XKDblbaVKvWwx5VJ3MTUiSNjCvTXr5045MMppBWUoFbiEMaTxH5v3szYMLKnyeaWoyy%2BZyGmI2iFm5E9G0EIHAhH6mOF28Li%2B25hiDgJtVNleCSvWBstbV2REC8bjoIxKkjWNAYsTXEgGjbEOVs33Z4Ybb41QxE2DI8Boqb1LwlFrK3Au64GfmMSxfrVY%2BgXAwkqnfVKljEK2bpmsm9G9pQzJoqrZDPFVIFX4lLc9%2BuN0d3EOE5FnxvuN8%2BBtxFRMAn%2FzOEr%2BLdagh96FS%2BIrvSC9WTFtkQAhxIQ%2FZVxEbOIpYjeVNYJZ6s0xOo1lvxW%2BdwxlkkjkMYFFmKr2UUrwaQpFgnVo%2BZS9OqWbMUDvGf%2BOpgE4hEWe%2FzGhZ9aS%2B0FGqhbzBIs%2BFY6cEyRIC9N8pGOoWjnV8EsLzTS70Dd7UDdo3L%2BkzmXV5HIMTEtLWZeMBdEhuodmmP6wJZEEJbKoTkTgiXyjtLhJyWRGhCKjzrwMiYz9bAYb1Ck7p1kmBO5SMwr60NpkoBNEA80jZ66v7i0ruA%2BFtU08GYv7nrUKbODzhbQ1uJZ17Tna1tck51nnYgq%2F8IF4vUUiDsogXgG6kvBR%2B6EjNyZKYxAwiuke%2B5pWabDoj7YYq%2FiRgG9jonAjxnKMV3LktaTh%2F4h7pZz0CEOukIcfmaIA2CgfVkxPu4Z42VPMZAgH3%2BwCrQtlTSuKE5VvEAPJSpyc0f5aNuM%2Bpgl89XycMR3l5BmFTiCKny%2FqQpouf1UAcDJZHHpvVGJzGFdDKs7KuddA15n%2BEn%2BOXMCb4eq7Z89gUMDsK3cM7WBkusTTTSQFnUg0VAdn6H2hIRhEcZYtnponj9KBXLGSCrydbgTVZPls2Tk6nYQFEmJPeMpo0x1kilL1VOeCKUt0xEIGdstQoCZO5wOPuyT8WH29yTHDU5zRvguT0%2FBl2HJtVqtvdOR4cFn0gRN2VxYgu%2Fb3JdPHEqCN9v77%2F1v5%2F53t1k42%2F4XmBvg71zWzmUucM6dy8ye6cJyWe9NnD%2BsXGbu4lK8vnrM92RF2%2BrODCrKvCORQpRiyiKOklZqysO5PHOGrdTUuPGhGujsf5sdcpXBAGykMPtIOey61Y55HYW%2Bqx%2FzTyYO58LFsfvl42Chtwcljl3wfB9xyPD2mrpw%2FI6i8blHHPDST7fLeD8sDG9YwrB7CKOqI4u84ZntOwNfHON05ExK8OC5T1Bgnx1Jxcd7SvqHq3aNlyeyweVv42%2Fz9FaZPxJr7R8uBsCa2Xt9qXMvp0mIOzYLypHOveTX6o8K%2BVjt7x72zX8%3D) работы основной программы 