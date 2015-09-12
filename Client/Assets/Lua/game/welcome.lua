---------------------------------------------------------------------------------------------------
--===============================================================================================--
--filename: welcome.lua
--data:2015.4.17
--author:pu
--desc:
--===============================================================================================--
---------------------------------------------------------------------------------------------------

local welcome = LuaItemManager:getItemObject("welcome")
local StateManager = StateManager
local delay = delay
local LuaHelper=LuaHelper
local CUtils = CUtils
local getValue = getValue --多国语言
local showTips = showTips --显示提示
-----------------------net--------------------
local Proxy = Proxy
local NetAPIList = NetAPIList
local NetMsgHelper = NetMsgHelper

--UI资源
welcome.assets=
{
     Asset("welcome.u3d")
    -- Asset("youresource1.u3d",{"yourItemName"})
}

------------------private-----------------


------------------public------------------
-- 资源加载完成时候调用方法
function welcome:onAssetsLoad(items)
	-- local ReferScript = LuaHelper.GetComponent(self.assets[1].root,"ReferGameObjects") 
	-- local ReferScript1 = LuaHelper.GetComponent(self.assets[2].items["yourItemName"],"ReferGameObjects")
	local fristView = LuaHelper.Find("Frist")
	if fristView then LuaHelper.Destroy(fristView) end
--	fristView = nil 
-- Loader:clearSharedAB()
end


--点击事件
function welcome:onClick(obj,arg)
	local cmd =obj.name
	print(arg)
    print("you are click"..cmd)
end


--点击事件
function welcome:onDrag(obj,arg)
	local cmd =obj.name
	print(arg)
    print("you are onDrag"..cmd)
end

--显示时候调用
function welcome:onShowed( ... )

end

--初始化函数只会调用一次
function welcome:initialize()

end