# forest-view
Sample Game for practicing game optimization (reduce draw call, object pooling, resource load)

There are some changes that I've made into the game, including:
- Add `UnloadUnusedAssets` into Audio Manager to make sure only 
- Create Texture Atlas for the Main Menu buttons
- Implement Object Pooling on Mushroom Spawner
- Implement static batching


After Optimization
- With Audio
![image](https://user-images.githubusercontent.com/20859739/187161705-45692d21-105c-446d-aa8f-69d8ac84cb98.png)
- Without Audio
![image](https://user-images.githubusercontent.com/20859739/187162001-0895c99f-58a9-4feb-bf14-6b17f29c29f9.png)
- Main Menu
![image](https://user-images.githubusercontent.com/20859739/187162193-b27ad729-e8bb-4fed-8b68-60aabb1ae662.png)
- Gameplay
![image](https://user-images.githubusercontent.com/20859739/187162275-6295d418-cbd9-4103-9fc0-5504d5f2954f.png)

