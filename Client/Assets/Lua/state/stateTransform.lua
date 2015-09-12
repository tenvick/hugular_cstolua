------------------------------------------------
--  Copyright © 2013-2014   Hugula: Arpg game Engine
--   
--  author pu
------------------------------------------------
local transform = LuaItemManager:getItemObject("transform")
transform.priority=100
transform.assets=
{
  Asset("loading.u3d")
}

function transform:onFocus( ... )
    if self.assetsLoaded then 
        self:show()  
        self:onShowed()     
    else
        self.assetLoader:load(self.assets)  
    end
end

function transform:onClick( ... )
	return true
end

function transform:onAssetsLoad(items)
  self:show()
end
